using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace ListBoxExt
{
    public class ListBoxEx : System.Windows.Forms.ListBox
    {
        private bool m_isDragDropCopySource = true;

        [Category("Behavior (drag-and-drop)"), DefaultValue(true),
          Description("Indicates whether ...")]
        public bool IsDragDropCopySource
        {
            get { return m_isDragDropCopySource; }
            set { m_isDragDropCopySource = value; }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }
    }
}
