using System;
using Gtk;

namespace partsTest2 {
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ComboWidget : Gtk.Bin {
		public ComboWidget() {
			this.Build();
		}

        public string bindingProperyName = "";

        public ComboBox Combo {
            get {
                return combobox18;
            }
        }	

    }
}
