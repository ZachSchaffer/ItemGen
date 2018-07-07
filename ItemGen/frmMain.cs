using System;
using System.IO;
using System.Windows.Forms;

namespace ItemGen
{
    public partial class frmMain : Form
    {
        public Item item;

        public frmMain()
        {
            InitializeComponent();
            UpdateUi();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                MessageBox.Show("You must create an item first!");
            }

            else
            {
                var filter = "Item Files (*.itm)|*.itm|All Files (*.*)|*.*";
                switch (item.itemType)
                {
                    case Item.ItemType.Armor:
                        filter = "Armor Files (*.armr)|*.armr|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Weapon:
                        filter = "Weapon Files (*.wpn)|*.wpn|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Equipment:
                        filter = "Equipment Files (*.equip)|*.equip|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Ammunition:
                        filter = "Ammunition Files (*.ammo)|*.ammo|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Cyberware:
                        filter = "Cyberware Files (*.cw)|*.cw|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Bioware:
                        filter = "Bioware Files (*.bio)|*.bio|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Vehicle:
                        filter = "Vehicle Files (*.veh)|*.veh|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Cyberdeck:
                        filter = "Cyberdeck Files (*.cdk)|*.cdk|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.DroneMaster:
                        filter = "Drone Files (*.drn)|*.drn|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Explosives:
                        filter = "Explosives Files (*.exp)|*.exp|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.WeaponMod:
                        filter = "WeaponMod Files (*.wepmod)|*.wepmod|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Program:
                        filter = "Program Files (*.prog)|*.prog|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.CyberMod:
                        filter = "Cyberware Mod Files (*.cybermod)|*.cybermod|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.VehicleMod:
                        filter = "Vehicle Mod Files (*.vmod)|*.vmod|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Drug:
                        filter = "Drug Files (*.drug)|*.drug|All Files (*.*)|*.*";
                        break;
                    case Item.ItemType.Misc:
                        break;
                    default:
                        filter = "Item Files (*.itm)|*.itm|All Files (*.*)|*.*";
                        break;
                }
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = filter
                };
                var strShowFileName = string.Empty;
                var strFile = item.FileName.Split(Path.DirectorySeparatorChar);
                strShowFileName = strFile[strFile.Length - 1];

                if (string.IsNullOrEmpty(strShowFileName))
                    strShowFileName = item.Name;

                saveFileDialog.FileName = strShowFileName;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    item.FileName = saveFileDialog.FileName;
                    item.Save();
                }
            }
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSelectItem = new frmSelectItemType();
            formSelectItem.ShowDialog();
            if (formSelectItem.DialogResult == DialogResult.OK)
            {
                item = formSelectItem.ReturnItem;
                UpdateUi();
            }

            formSelectItem.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void UpdateUi()
        {
            if (item == null)
            {
                UniversalPropertiesBox.Visible = false;
                SpecialPropertiesBox.Visible = false;
                btnSet.Visible = false;
                foreach (Control c in UniversalPropertiesBox.Controls) c.Visible = false;
            }
            else
            {
                foreach (Control c in UniversalPropertiesBox.Controls) c.Visible = true;
                foreach (Control c in SpecialPropertiesBox.Controls) c.Visible = false;
                UniversalPropertiesBox.Visible = true;
                SpecialPropertiesBox.Visible = true;
                btnSet.Visible = true;

                boxName.Text = item.Name;
                boxDesc.Text = item.Description;
                boxRules.Text = item.Rules;
                boxAvail.Text = item.Avail;
                boxCost.Text = item.Cost.ToString();
                boxDR.Text = item.DeviceRating.ToString();
                boxWeight.Text = item.Weight.ToString();

                switch (item.itemType)
                {
                    case Item.ItemType.Armor:
                    {
                        var item = (Armor) this.item;
                        slbl1.Text = "Armor Rating";
                        slbl1.Visible = true;
                        sbox1.Visible = true;
                        sbox1.Text = item.ArmorRating.ToString();

                        slbl2.Text = "Capacity";
                        slbl2.Visible = true;
                        sbox2.Visible = true;
                        sbox2.Text = item.Capacity.ToString();

                        break;
                    }

                    case Item.ItemType.Weapon:
                    {
                        var item = (Weapon) this.item;
                        sdrop1.Visible = true;
                        sdrop1.DataSource = new[]
                            {"Pistol", "SMG", "Assault Rifle", "Sniper Rifle", "Shotgun", "Blade", "Blunt", "Special"};
                        sdrop1.Text = item.SubCategory;

                        slbl1.Text = "Accuracy";
                        slbl1.Visible = true;
                        sbox1.Visible = true;
                        sbox1.Text = item.Accuracy.ToString();

                        slbl2.Text = "Damage Value";
                        slbl2.Visible = true;
                        sbox2.Visible = true;
                        sbox2.Text = item.DamageValue.ToString();

                        slbl3.Text = "Armor Pen";
                        slbl3.Visible = true;
                        sbox3.Visible = true;
                        sbox3.Text = item.ArmorPen.ToString();

                        sdrop2.Visible = true;
                        slbl7.Visible = true;
                        slbl8.Text = "Fire Mode";
                        sdrop2.DataSource = new[] {"Single", "Semi Auto", "Full Auto", "Burst"};
                        sdrop2.Text = item.FireMode;

                        slbl4.Text = "Recoil Comp";
                        slbl4.Visible = true;
                        sbox4.Visible = true;
                        sbox4.Text = item.RecoilCompensation.ToString();

                        slbl5.Text = "Ammo Capacity";
                        slbl5.Visible = true;
                        sbox5.Visible = true;
                        sbox5.Text = item.AmmoCapacity.ToString();


                        ModSlotsBox.Visible = true;
                        slbl7.Text = "Subcategory";
                        slbl8.Visible = true;

                        checkBox1.Checked = item.Modslots[0];
                        checkBox2.Checked = item.Modslots[1];
                        checkBox3.Checked = item.Modslots[2];
                        checkBox4.Checked = item.Modslots[3];
                        checkBox5.Checked = item.Modslots[4];
                        checkBox6.Checked = item.Modslots[5];

                        break;
                    }

                    case Item.ItemType.Ammunition:
                    {
                        var item = (Ammunition) this.item;
                        sdrop1.Visible = true;
                        slbl7.Text = "Subcategory";
                        slbl7.Visible = true;
                        sdrop1.DataSource = new[]
                            {"Pistol", "SMG", "Assault Rifle", "Sniper Rifle", "Shotgun", "Blade", "Blunt", "Special"};
                        sdrop1.Text = item.SubCategory;

                        break;
                    }

                    case Item.ItemType.Cyberware:
                    {
                        var item = (Cyberware) this.item;
                        sdrop1.Visible = true;
                        slbl7.Visible = true;
                        slbl7.Text = "Grade";
                        sdrop1.DataSource = new[]
                        {
                            "Standard", "Used", "Alphaware", "Betaware", "Omegaware", "Deltaware"
                        };
                        sdrop1.Text = item.Grade;

                        slbl1.Text = "Agility";
                        slbl1.Visible = true;
                        sbox1.Visible = true;
                        sbox1.Text = item.Agility.ToString();

                        slbl2.Text = "Strength";
                        slbl2.Visible = true;
                        sbox2.Visible = true;
                        sbox2.Text = item.Strength.ToString();

                        slbl3.Text = "Capacity";
                        slbl3.Visible = true;
                        sbox3.Visible = true;
                        sbox3.Text = item.Capacity.ToString();

                        sdrop2.Visible = true;
                        sdrop2.Text = item.Category;
                        slbl8.Text = "Subcategory";
                        slbl8.Visible = true;
                        sdrop2.DataSource = new[]
                        {
                            "Cyberlimb", "Bodyware", "Cosmetic", "Cyberlimb Enhancement", "Earware", "Eyeware",
                            "Implanted Weapon", "Headware", "Nanocybernetics"
                        };


                        break;
                    }

                    case Item.ItemType.Bioware:
                    {
                        var item = (Bioware) this.item;
                        sdrop1.Visible = true;
                        slbl7.Text = "Grade";
                        slbl7.Visible = true;
                        sdrop1.DataSource = new[]
                        {
                            "Standard", "Used", "Alphaware", "Betaware", "Omegaware", "Deltaware"
                        };
                        sdrop1.Text = item.Grade;

                        sdrop2.Visible = true;
                        slbl8.Text = "Subcategory";
                        slbl8.Visible = true;
                        sdrop1.DataSource = new[]
                        {
                            "Basic", "Bioweapon", "Cosmetic", "Cultured", "Gene Mods"
                        };
                        sdrop2.Text = item.Category;

                        break;
                    }

                    case Item.ItemType.Vehicle:
                    {
                        var item = (Vehicle) this.item;

                        slbl1.Text = "Body";
                        slbl1.Visible = true;
                        sbox1.Visible = true;
                        sbox1.Text = item.Body.ToString();

                        slbl2.Text = "Speed";
                        slbl2.Visible = true;
                        sbox2.Visible = true;
                        sbox2.Text = item.Speed.ToString();

                        slbl3.Text = "Handling";
                        slbl3.Visible = true;
                        sbox3.Visible = true;
                        sbox3.Text = item.Handling.ToString();

                        slbl4.Text = "Armor";
                        slbl4.Visible = true;
                        sbox4.Visible = true;
                        sbox4.Text = item.Armor.ToString();

                        slbl5.Text = "Seats";
                        slbl5.Visible = true;
                        sbox5.Visible = true;
                        sbox5.Text = item.Seats.ToString();

                        slbl6.Text = "Upgrade Capacity";
                        slbl6.Visible = true;
                        sbox6.Visible = true;
                        sbox6.Text = item.UpCap.ToString();

                        break;
                    }

                    case Item.ItemType.Cyberdeck:
                    {
                        var item = (Cyberdeck) this.item;

                        slbl1.Text = "Firewall";
                        slbl1.Visible = true;
                        sbox1.Visible = true;
                        sbox1.Text = item.Firewall.ToString();

                        slbl2.Text = "Drone Limit";
                        slbl2.Visible = true;
                        sbox2.Visible = true;
                        sbox2.Text = item.ProgramLimit.ToString();
                        break;
                    }

                    case Item.ItemType.Explosives:
                    {
                        var item = (Explosives) this.item;

                        slbl1.Text = "AoE";
                        slbl1.Visible = true;
                        sbox1.Visible = true;
                        sbox2.Text = item.Area.ToString();

                        slbl2.Text = "Damage Value";
                        slbl2.Visible = true;
                        sbox2.Visible = true;
                        sbox2.Text = item.Dv.ToString();

                        break;
                    }

                    case Item.ItemType.Equipment:
                    {
                        var item = (Equipment) this.item;
                        SpecialPropertiesBox.Visible = true;
                        break;
                    }

                    case Item.ItemType.DroneMaster:
                    {
                        var item = (Drone) this.item;

                        slbl1.Text = "Firewall";
                        slbl1.Visible = true;
                        sbox1.Visible = true;
                        sbox2.Text = item.Firewall.ToString();

                        slbl2.Text = "Drone Limit";
                        slbl2.Visible = true;
                        sbox2.Visible = true;
                        sbox2.Text = item.DroneLimit.ToString();
                        break;
                    }

                    case Item.ItemType.WeaponMod:
                    {
                        var item = (WeaponMod)this.item;
                        sdrop1.Visible = true;
                        slbl7.Text = "Mod Slot";
                        slbl7.Visible = true;
                        sdrop1.DataSource = new[]
                            {"Pistol", "SMG", "Assault Rifle", "Sniper Rifle", "Shotgun", "Blade", "Blunt", "Special"};
                        sdrop1.Text = item.slot;

                        break;
                    }
                    /*case Item.ItemType.Program:
                    {
                        var item = (Programs)this.item;
                        break;
                    }
                    case Item.ItemType.CyberMod:
                    {
                        var item = (CyberMod)this.item;
                        break;
                    }
                    case Item.ItemType.VehicleMod:
                    {
                        var item = (VehicleMod)this.item;
                        break;
                    }
                    case Item.ItemType.Drug:
                    {
                        var item = (Drug)this.item;
                        break;
                    }*/

                    case Item.ItemType.Misc:
                        break;
                }
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(boxAvail.Text)) item.Avail = boxAvail.Text;
            if (!string.IsNullOrEmpty(boxCost.Text)) item.Cost = int.Parse(boxCost.Text);
            if (!string.IsNullOrEmpty(boxDesc.Text)) item.Description = boxDesc.Text;
            if (!string.IsNullOrEmpty(boxDR.Text)) item.DeviceRating = int.Parse(boxDR.Text);
            if (!string.IsNullOrEmpty(boxRules.Text)) item.Rules = boxRules.Text;
            if (!string.IsNullOrEmpty(boxWeight.Text)) item.Weight = double.Parse(boxWeight.Text);
            if (!string.IsNullOrEmpty(boxName.Text)) item.Name = boxName.Text;

            switch (item.itemType)
            {
                case Item.ItemType.Armor:
                {
                    var item = (Armor) this.item; //This is apparently the only way I can downcast... 
                    if (!string.IsNullOrEmpty(sbox1.Text)) item.ArmorRating = int.Parse(sbox1.Text);
                    if (!string.IsNullOrEmpty(sbox2.Text)) item.Capacity = int.Parse(sbox2.Text);
                    if (!string.IsNullOrEmpty(sdrop1.Text)) item.SubCategory = sdrop1.Text;
                    break;
                }

                case Item.ItemType.Weapon:
                {
                    var item = (Weapon) this.item;


                    if (!string.IsNullOrEmpty(sdrop1.Text)) item.SubCategory = sdrop1.Text;
                    if (!string.IsNullOrEmpty(sbox1.Text)) item.Accuracy = int.Parse(sbox1.Text);
                    if (!string.IsNullOrEmpty(sbox2.Text)) item.DamageValue = int.Parse(sbox2.Text);
                    if (!string.IsNullOrEmpty(sbox3.Text)) item.ArmorPen = int.Parse(sbox3.Text);
                    if (!string.IsNullOrEmpty(sdrop2.Text)) item.FireMode = sdrop2.Text;
                    if (!string.IsNullOrEmpty(sbox4.Text)) item.RecoilCompensation = int.Parse(sbox4.Text);
                    if (!string.IsNullOrEmpty(sbox5.Text)) item.AmmoCapacity = int.Parse(sbox5.Text);

                    item.Modslots[0] = checkBox1.Checked;
                    item.Modslots[1] = checkBox2.Checked;
                    item.Modslots[2] = checkBox3.Checked;
                    item.Modslots[3] = checkBox4.Checked;
                    item.Modslots[4] = checkBox5.Checked;
                    item.Modslots[5] = checkBox6.Checked;

                    break;
                }

                case Item.ItemType.Ammunition:
                {
                    var item = (Ammunition) this.item;
                    if (!string.IsNullOrEmpty(sdrop1.Text)) item.SubCategory = sdrop1.Text;
                    break;
                }

                case Item.ItemType.Cyberware:
                {
                    var item = (Cyberware) this.item;
                    if (!string.IsNullOrEmpty(sdrop1.Text)) item.Grade = sdrop1.Text;
                    if (!string.IsNullOrEmpty(sdrop2.Text)) item.Category = sdrop2.Text;
                    if (!string.IsNullOrEmpty(sbox1.Text)) item.Agility = int.Parse(sbox1.Text);
                    if (!string.IsNullOrEmpty(sbox2.Text)) item.Strength = int.Parse(sbox2.Text);
                    if (!string.IsNullOrEmpty(sbox3.Text)) item.Capacity = int.Parse(sbox3.Text);

                    break;
                }

                case Item.ItemType.Bioware:
                {
                    var item = (Bioware) this.item;
                    if (!string.IsNullOrEmpty(sdrop1.Text)) item.Grade = sdrop1.Text;
                    if (!string.IsNullOrEmpty(sdrop2.Text)) item.Category = sdrop2.Text;
                    break;
                }

                case Item.ItemType.Vehicle:
                {
                    var item = (Vehicle) this.item;
                    if (!string.IsNullOrEmpty(sbox1.Text)) item.Body = int.Parse(sbox1.Text);
                    if (!string.IsNullOrEmpty(sbox2.Text)) item.Speed = int.Parse(sbox2.Text);
                    if (!string.IsNullOrEmpty(sbox3.Text)) item.Handling = int.Parse(sbox3.Text);
                    if (!string.IsNullOrEmpty(sbox4.Text)) item.Armor = int.Parse(sbox4.Text);
                    if (!string.IsNullOrEmpty(sbox5.Text)) item.Seats = int.Parse(sbox5.Text);
                    if (!string.IsNullOrEmpty(sbox6.Text)) item.UpCap = int.Parse(sbox6.Text);
                    break;
                }

                case Item.ItemType.Cyberdeck:
                {
                    var item = (Cyberdeck) this.item;
                    if (!string.IsNullOrEmpty(sbox1.Text)) item.Firewall = int.Parse(sbox1.Text);
                    if (!string.IsNullOrEmpty(sbox2.Text)) item.ProgramLimit = int.Parse(sbox2.Text);

                    break;
                }

                case Item.ItemType.Explosives:
                {
                    var item = (Explosives) this.item;
                    if (!string.IsNullOrEmpty(sbox1.Text)) item.Area = int.Parse(sbox1.Text);
                    if (!string.IsNullOrEmpty(sbox2.Text)) item.Dv = int.Parse(sbox2.Text);
                    break;
                }

                case Item.ItemType.Equipment:
                {
                    var item = (Equipment) this.item;
                    break;
                }

                case Item.ItemType.DroneMaster:
                {
                    var item = (Drone)this.item;
                    if (!string.IsNullOrEmpty(sbox1.Text)) item.Firewall = int.Parse(sbox1.Text);
                    if (!string.IsNullOrEmpty(sbox2.Text)) item.DroneLimit = int.Parse(sbox2.Text);
                        break;
                }
                case Item.ItemType.WeaponMod:
                {
                    var item = (WeaponMod)this.item;
                    if (!string.IsNullOrEmpty(sdrop1.Text)) item.slot = sdrop1.Text;
                    break;
                }

                case Item.ItemType.Misc:
                    break;
            }
            UpdateUi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                LoadItem(openFileDialog.FileName);
            UpdateUi();
        }

        private void LoadItem(string fileName)
        {
            if (File.Exists(fileName)) //TODO: Switch extension based on type
            {
                if (fileName.EndsWith(".itm"))
                {
                    item = new Item();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".armr"))
                {
                    item = new Armor();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".wpn"))
                {
                    item = new Weapon();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".equip"))
                {
                    item = new Equipment();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".ammo"))
                {
                    item = new Ammunition();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".cw"))
                {
                    item = new Cyberware();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".bio"))
                {
                    item = new Bioware();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".veh"))
                {
                    item = new Vehicle();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".cdk"))
                {
                    item = new Cyberdeck();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".drn"))
                {
                    item = new Drone();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".exp"))
                {
                    item = new Explosives();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".wepmod"))
                {
                    item = new WeaponMod();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".prog"))
                {
                    item = new Programs();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".cybermod"))
                {
                    item = new CyberMod();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".vmod"))
                {
                    item = new VehicleMod();
                    item.FileName = fileName;
                    item.Load();
                }
                if (fileName.EndsWith(".drug"))
                {
                    item = new Drug();
                    item.FileName = fileName;
                    item.Load();
                }


                UpdateUi();
            }
        }
    }
}