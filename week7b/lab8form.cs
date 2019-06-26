using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week7b
{
    public partial class lab8form : Form
    {
        //class propoties
        public string UseName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// this is the constructor for lab8form
        /// </summary>
        public lab8form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is the event handler for the submitbottom click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submitbutton_Click(object sender, EventArgs e)
        {
            UseName = NametextBox.Text;

            UserAge = float.Parse(AgetextBox.Text);

            outputlable.Text = NametextBox.Text + " " + AgetextBox.Text;

            ClearForm();
        }

        private void ClearForm()
        {
            NametextBox.Clear();
            AgetextBox.Clear();
            Submitbutton.Enabled = false;
        }

        /// <summary>
        /// this is the event handler for agetextbox textchange event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgetextBox_TextChanged(object sender, EventArgs e)
        {
            if (AgetextBox.Text.Length > 0)
            {
                try
                {
                    float.Parse(AgetextBox.Text);
                    Submitbutton.Enabled = true;
                }
                catch 
                {
                    Submitbutton.Enabled = false;
                }
                Submitbutton.Enabled = true;
            }
            else
            {
                Submitbutton.Enabled = false;
            }
        }
        /// <summary>
        /// this is the event handler for the lab8form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lab8form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// this is an event handler for the nametextbox textchange event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            Submitbutton.Enabled = (NametextBox.Text.Length < 2)?false:true;

        }
    }
}
