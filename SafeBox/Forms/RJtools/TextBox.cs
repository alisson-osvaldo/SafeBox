using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBox.Forms.Buttons
{
    [DefaultEvent("_TextChanged")]
    public partial class TextBox : Form
    {

        
        //Filds
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private bool inderlinebdStyle = false;
        private bool isFocused = false;

        private int borderRadius = 0;

        [Category("RJ Code Advance")]
        public int BorderRadius {
            get 
            {
                return borderRadius;
            }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw Control
                }
                
            }
        }

        #region -> Overridden methods
        //protected override void OnResize(EventArgs e)

        //Events
        public event EventHandler _TextChanged;

        #endregion


        public TextBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
