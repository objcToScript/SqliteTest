
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label label5;

	private global::Gtk.TextView artistText;

	private global::Gtk.Label label7;

	private global::Gtk.TextView titleText;

	private global::Gtk.Label label6;

	private global::Gtk.CheckButton effectiveBtn;

	private global::Gtk.Button makeBtn;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Fixed fixed3;

	private global::Gtk.Button reNewBtn;

	private global::Gtk.Button updateBtn;

	private global::Gtk.Button deleteBtn;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TreeView treeview;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Artist");
		this.hbox1.Add(this.label5);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label5]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.artistText = new global::Gtk.TextView();
		this.artistText.CanFocus = true;
		this.artistText.Name = "artistText";
		this.hbox1.Add(this.artistText);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.artistText]));
		w2.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Title");
		this.hbox1.Add(this.label7);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label7]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.titleText = new global::Gtk.TextView();
		this.titleText.CanFocus = true;
		this.titleText.Name = "titleText";
		this.hbox1.Add(this.titleText);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.titleText]));
		w4.Position = 3;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("有効");
		this.hbox1.Add(this.label6);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label6]));
		w5.Position = 4;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.effectiveBtn = new global::Gtk.CheckButton();
		this.effectiveBtn.CanFocus = true;
		this.effectiveBtn.Name = "effectiveBtn";
		this.effectiveBtn.Label = "";
		this.effectiveBtn.DrawIndicator = true;
		this.effectiveBtn.UseUnderline = true;
		this.hbox1.Add(this.effectiveBtn);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.effectiveBtn]));
		w6.Position = 5;
		// Container child hbox1.Gtk.Box+BoxChild
		this.makeBtn = new global::Gtk.Button();
		this.makeBtn.CanFocus = true;
		this.makeBtn.Name = "makeBtn";
		this.makeBtn.UseUnderline = true;
		this.makeBtn.Label = global::Mono.Unix.Catalog.GetString("作成");
		this.hbox1.Add(this.makeBtn);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.makeBtn]));
		w7.Position = 6;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		w8.Padding = ((uint)(5));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.fixed3 = new global::Gtk.Fixed();
		this.fixed3.Name = "fixed3";
		this.fixed3.HasWindow = false;
		this.hbox3.Add(this.fixed3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.fixed3]));
		w9.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.reNewBtn = new global::Gtk.Button();
		this.reNewBtn.CanFocus = true;
		this.reNewBtn.Name = "reNewBtn";
		this.reNewBtn.UseUnderline = true;
		this.reNewBtn.Label = global::Mono.Unix.Catalog.GetString("新規");
		this.hbox3.Add(this.reNewBtn);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.reNewBtn]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.updateBtn = new global::Gtk.Button();
		this.updateBtn.CanFocus = true;
		this.updateBtn.Name = "updateBtn";
		this.updateBtn.UseUnderline = true;
		this.updateBtn.Label = global::Mono.Unix.Catalog.GetString("更新");
		this.hbox3.Add(this.updateBtn);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.updateBtn]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.deleteBtn = new global::Gtk.Button();
		this.deleteBtn.CanFocus = true;
		this.deleteBtn.Name = "deleteBtn";
		this.deleteBtn.UseUnderline = true;
		this.deleteBtn.Label = global::Mono.Unix.Catalog.GetString("削除");
		this.hbox3.Add(this.deleteBtn);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.deleteBtn]));
		w12.PackType = ((global::Gtk.PackType)(1));
		w12.Position = 3;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox1.Add(this.hbox3);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeview = new global::Gtk.TreeView();
		this.treeview.CanFocus = true;
		this.treeview.Name = "treeview";
		this.GtkScrolledWindow.Add(this.treeview);
		this.vbox1.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
		w15.Position = 2;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 527;
		this.DefaultHeight = 353;
		this.Show();
		this.makeBtn.Clicked += new global::System.EventHandler(this.OnMakeBtnClicked);
		this.reNewBtn.Clicked += new global::System.EventHandler(this.OnReNewBtnClicked);
		this.updateBtn.Clicked += new global::System.EventHandler(this.OnUpdateBtnClicked);
		this.deleteBtn.Clicked += new global::System.EventHandler(this.OnDeleteBtnClicked);
	}
}