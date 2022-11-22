using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace File_Manager_Winform
{
    internal class ComboBoxWithImage:ComboBox
    {
        private Image _image;
        public Image image
        {
            get { return _image; }
            set { _image = value; }
        }
        
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            
        }
    }
}
