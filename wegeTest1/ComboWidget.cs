using System;
using Gtk;
namespace wegeTest1 {
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ComboWidget : Gtk.Bin {
		public ComboWidget() {
			this.Build();
		}

		public string bindingProperyName = "";

		public ComboBox _mkComoboBox() {
			return combobox15;
		}

		public ComboBox Combo {
			get {
				return combobox15;
			}
		}

	}
}
