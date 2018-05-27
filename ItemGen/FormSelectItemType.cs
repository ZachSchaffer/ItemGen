using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemGen
{
    public partial class FormSelectItemType : Form
    {
        public Item ReturnItem;

        public FormSelectItemType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                {
                    this.ReturnItem = new Armor();
                    break;
                }

                case 1:
                {
                    this.ReturnItem = new Weapon();
                    break;
                }
                case 2:
                {
                    this.ReturnItem = new Equipment();
                    break;
                }
                case 3:
                {
                    this.ReturnItem = new Ammunition();
                    break;
                }
                case 4:
                {
                    this.ReturnItem = new Cyberware();
                    break;
                }
                case 5:
                {
                    this.ReturnItem = new Vehicle();
                    break;
                }
                case 6:
                {
                    this.ReturnItem = new Cyberdeck();
                    break;
                }
                case 7:
                {
                    this.ReturnItem = new Drone();
                    break;
                }
                case 8:
                {
                    this.ReturnItem = new Explosives();
                    break;
                }
                case 9:
                {
                    this.ReturnItem = new Item();
                    break;
                }
                default:
                    break;
            }

            this.DialogResult = DialogResult.OK;

            }
        }
    }
