
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.RadioButton ckbN;
	private global::Gtk.RadioButton ckbD;
	private global::Gtk.RadioButton ckbQ;
	private global::Gtk.Button btnInsertMoney;
	private global::Gtk.Label lblMoneyInside;
	private global::Gtk.Label label2;
	private global::Gtk.Label label3;
	private global::Gtk.Label label5;
	private global::Gtk.Label lblProduct;
	private global::Gtk.Label lblCarryOver;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Hot Chocolate Machine");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ckbN = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Nickel (5 ¢)"));
		this.ckbN.CanFocus = true;
		this.ckbN.Name = "ckbN";
		this.ckbN.DrawIndicator = true;
		this.ckbN.UseUnderline = true;
		this.ckbN.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.fixed1.Add (this.ckbN);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.ckbN]));
		w1.X = 20;
		w1.Y = 20;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ckbD = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Dime (10 ¢)"));
		this.ckbD.CanFocus = true;
		this.ckbD.Name = "ckbD";
		this.ckbD.DrawIndicator = true;
		this.ckbD.UseUnderline = true;
		this.ckbD.Group = this.ckbN.Group;
		this.fixed1.Add (this.ckbD);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.ckbD]));
		w2.X = 20;
		w2.Y = 40;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ckbQ = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Quarter (25 ¢)"));
		this.ckbQ.CanFocus = true;
		this.ckbQ.Name = "ckbQ";
		this.ckbQ.DrawIndicator = true;
		this.ckbQ.UseUnderline = true;
		this.ckbQ.Group = this.ckbN.Group;
		this.fixed1.Add (this.ckbQ);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.ckbQ]));
		w3.X = 20;
		w3.Y = 60;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnInsertMoney = new global::Gtk.Button ();
		this.btnInsertMoney.CanFocus = true;
		this.btnInsertMoney.Name = "btnInsertMoney";
		this.btnInsertMoney.UseUnderline = true;
		this.btnInsertMoney.Label = global::Mono.Unix.Catalog.GetString ("Insert Money");
		this.fixed1.Add (this.btnInsertMoney);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnInsertMoney]));
		w4.X = 160;
		w4.Y = 16;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblMoneyInside = new global::Gtk.Label ();
		this.lblMoneyInside.Name = "lblMoneyInside";
		this.lblMoneyInside.LabelProp = global::Mono.Unix.Catalog.GetString ("0 ¢");
		this.fixed1.Add (this.lblMoneyInside);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblMoneyInside]));
		w5.X = 250;
		w5.Y = 65;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Money Inside:");
		this.fixed1.Add (this.label2);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
		w6.X = 160;
		w6.Y = 65;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Carry over:");
		this.fixed1.Add (this.label3);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label3]));
		w7.X = 20;
		w7.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Hot Chocolate:");
		this.fixed1.Add (this.label5);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label5]));
		w8.X = 20;
		w8.Y = 120;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblProduct = new global::Gtk.Label ();
		this.lblProduct.Name = "lblProduct";
		this.lblProduct.LabelProp = global::Mono.Unix.Catalog.GetString ("Not yet");
		this.fixed1.Add (this.lblProduct);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblProduct]));
		w9.X = 160;
		w9.Y = 120;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblCarryOver = new global::Gtk.Label ();
		this.lblCarryOver.Name = "lblCarryOver";
		this.lblCarryOver.LabelProp = global::Mono.Unix.Catalog.GetString ("0 ¢");
		this.fixed1.Add (this.lblCarryOver);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblCarryOver]));
		w10.X = 160;
		w10.Y = 100;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 295;
		this.DefaultHeight = 169;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnInsertMoney.Clicked += new global::System.EventHandler (this.OnBtnInsertMoneyClicked);
	}
}
