using System;
using Gdk;
using Gtk;


public partial class MainWindow {

	public void _mkLable() {

		label6.Text = "testtest";		

	}

	public void _mkToglleBtn() {

		//チェックボックスをOnにする
		checkbutton5.Active = true;
		checkbutton5.Clicked += toggleClickedCallback;

		checkbutton6.Active = false;
		checkbutton6.Clicked += delegate (object obj, EventArgs args) {
			if(((ToggleButton)obj).Active) {
				Console.WriteLine("Active");
			}
		};

	}

	void toggleClickedCallback(object obj, EventArgs args) {
		if(((ToggleButton)obj).Active) {

		}		
	}

	public void _mkRadioBtn() {

		//ラジオボックスをOnにする
		radiobutton5.Active = true;
		radiobutton5.Clicked += radioBtnClickedCallback;

		radiobutton6.Active = false;
		radiobutton6.Clicked += delegate (object obj, EventArgs args) {
			if(((RadioButton)obj).Active) {
				Console.WriteLine("Active");
			}
		};
		
	}

	void radioBtnClickedCallback(object obj, EventArgs args) {
		if(((RadioButton)obj).Active) {
			Console.WriteLine("Active");
		}
	}

	void _mkImage() {


	}

	void _mkTextView() {

		textview2.Buffer.Text = "testtest";

	}


	void _mkSnipTest() {

		spinbutton3.Value = 5;

	}


}
