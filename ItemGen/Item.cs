using System;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

public class Item
{
    enum Type : int 
    {
        Weapon
    }
    private String name;
    private Type type;

	public Item()
	{
        this.type = Type.Weapon;
	}
}
