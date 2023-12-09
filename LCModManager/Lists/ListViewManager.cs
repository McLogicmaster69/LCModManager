using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCModManager.Lists
{
    /// <summary>
    /// Manages the appearance and items of a list view
    /// </summary>
    public class ListViewManager
    {
        /// <summary>
        /// The list view that the class manages
        /// </summary>
        private ListView _list;

        /// <summary>
        /// The width ratio of each column in the list view
        /// </summary>
        private float[] _columnWidths;

        /// <summary>
        /// The column that gets any overflow space that cannot be divided among the ratios
        /// </summary>
        private int _overflowColumn;

        /// <summary>
        /// The index that has been selected by the user in the list view
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                if (_list.SelectedItems.Count == 0)
                    return -1;
                else
                    return _list.SelectedItems[0].Index;
            }
        }

        /// <summary>
        /// Initialises the manager with a list view
        /// </summary>
        /// <param name="list">The list the manager will manage</param>
        public ListViewManager(ListView list, int overflowColumn, ListColumnDetails[] columns)
        {
            if(columns.Length == 0)
                throw new Exception("List view manager cannot contain no columns");

            _list = list;
            _overflowColumn = overflowColumn;

            SetupProperties();
            SetupColumns(columns);
            SetupWidths(columns);
        }

        /// <summary>
        /// Setup for the properties of the list view
        /// </summary>
        private void SetupProperties()
        {
            _list.View = View.Details;
            _list.LabelEdit = false;
            _list.AllowColumnReorder = true;
            _list.CheckBoxes = false;
            _list.FullRowSelect = true;
            _list.GridLines = true;
            _list.Sorting = SortOrder.None;
            _list.MultiSelect = false;
            _list.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            _list.ColumnWidthChanging += CancelColumnResize;
        }

        /// <summary>
        /// Setup for the columns of the list view
        /// </summary>
        /// <param name="columns">Details about each column</param>
        private void SetupColumns(ListColumnDetails[] columns)
        {
            _list.Columns.Clear();
            foreach(ListColumnDetails column in columns)
            {
                _list.Columns.Add(column.Name, -2, column.Alignment);
            }
        }

        /// <summary>
        /// Setup for the width of each column within the list view
        /// </summary>
        /// <param name="columns">Details about each column</param>
        private void SetupWidths(ListColumnDetails[] columns)
        {
            float totalRatio = 0;
            foreach(ListColumnDetails column in columns)
            {
                totalRatio += column.WidthRatio;
            }

            if (totalRatio == 0)
                throw new Exception("Cannot have a total ratio of 0");

            _columnWidths = new float[columns.Length];
            for (int i = 0; i < columns.Length; i++)
            {
                _columnWidths[i] = columns[i].WidthRatio / totalRatio;
            }
        }

        /// <summary>
        /// Runs when the user tries to resize a column and prevents the user from doing so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelColumnResize(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = _list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        /// <summary>
        /// Update the width of each column based on the width of the whole list and the column width ratios
        /// </summary>
        /// <param name="newPanelWidth">Width of the list</param>
        public void UpdateWidth(int newPanelWidth)
        {
            int totalWidth = 0;
            for (int i = 0; i < _columnWidths.Length; i++)
            {
                int width = (int)Math.Floor(newPanelWidth * _columnWidths[i]);
                totalWidth += width;
                _list.Columns[i].Width = width;
            }

            _list.Columns[_overflowColumn].Width += newPanelWidth - totalWidth;
        }

        /// <summary>
        /// Adds a new item into the list view by passing a string array with each string corresponding to a column
        /// </summary>
        /// <param name="item">The item being added. Each element corresponds to the column</param>
        public void AddItem(string[] item)
        {
            if (item.Length != _columnWidths.Length)
                throw new Exception("Item does not have the correct number of columns");

            ListViewItem listViewItem = FormatItem(item);
            _list.Items.Add(listViewItem);
        }

        /// <summary>
        /// Updates an item in the list view at an index with a new array of strings
        /// </summary>
        /// <param name="index">The index of the item being updated</param>
        /// <param name="item">The item being added. Each element corresponds to the column</param>
        public void UpdateItem(int index, string[] item)
        {
            if (item.Length != _columnWidths.Length)
                throw new Exception("Item does not have the correct number of columns");

            ListViewItem listViewItem = FormatItem(item);
            _list.Items[index] = listViewItem;
        }

        /// <summary>
        /// Formats a string array into an item that can be stored in a list view
        /// </summary>
        /// <param name="item">A string array of each column</param>
        /// <returns>The formatted item</returns>
        public ListViewItem FormatItem(string[] item)
        {
            ListViewItem listViewItem = new ListViewItem(item[0]);
            for (int i = 1; i < item.Length; i++)
            {
                listViewItem.SubItems.Add(item[i]);
            }
            return listViewItem;
        }

        /// <summary>
        /// Clears the items in the manager and list view
        /// </summary>
        public virtual void ClearItems()
        {
            _list.Items.Clear();
        }
    }
}
