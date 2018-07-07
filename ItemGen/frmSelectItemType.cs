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
    public partial class frmSelectItemType : Form
    {
        public Item ReturnItem;

        public frmSelectItemType()
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
                    this.ReturnItem = new Cyberdeck();
                    break;
                }
                case 6:
                {
                    this.ReturnItem = new Bioware();
                    break;
                }
                case 7:
                {
                    this.ReturnItem = new Vehicle();
                    break;
                }
                case 8:
                {
                    this.ReturnItem = new Drone();
                    break;
                }
                case 9:
                {
                    this.ReturnItem = new Explosives();
                    break;
                }
                case 10:
                {
                    this.ReturnItem = new WeaponMod();
                    break;
                }
                case 11:
                {
                    this.ReturnItem = new Programs();
                    break;
                }
                case 12:
                {
                    this.ReturnItem = new CyberMod();
                    break;
                }
                case 13:
                {
                    this.ReturnItem = new VehicleMod();
                    break;
                }
                case 14:
                {
                    this.ReturnItem = new Drug();
                    break;
                }

                default:
                    break;
            }

            this.DialogResult = DialogResult.OK;

            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
