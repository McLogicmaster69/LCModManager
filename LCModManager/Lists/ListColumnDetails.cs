using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCModManager.Lists
{
    /// <summary>
    /// Details required to setup a list view manager column
    /// </summary>
    public struct ListColumnDetails
    {
        /// <summary>
        /// The name of the column
        /// </summary>
        public string Name;

        /// <summary>
        /// The ratio of width that this column occupies of the entire list width
        /// </summary>
        public float WidthRatio;

        /// <summary>
        /// The alignment of text within the column
        /// </summary>
        public HorizontalAlignment Alignment;

        /// <summary>
        /// Initialises column details
        /// </summary>
        /// <param name="name"></param>
        /// <param name="widthRatio"></param>
        /// <param name="alignment"></param>
        public ListColumnDetails(string name, float widthRatio, HorizontalAlignment alignment)
        {
            Name = name;
            WidthRatio = widthRatio;
            Alignment = alignment;
        }
    }
}
