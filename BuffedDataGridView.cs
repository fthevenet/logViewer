using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTH.Utils.LogViewer
{

    public class BuffedDataGridView : System.Windows.Forms.DataGridView
    {
        public BuffedDataGridView()
            : base()
        {
            this.DoubleBuffered = true;


        }




    }
}
