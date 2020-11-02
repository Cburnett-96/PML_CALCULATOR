
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PML_CALCULATOR
{

	public partial class Unit : Form
	{

		//DISTANCE
		double millimeter, centimeter, decimeter, meter, kilometer, inches, foot, yard, mile, nautical, light;
		//ARES
		double millimeter2,centimeter2,meter2,are,hectare,kilometer2,foot2,yard2,acre;
		//VOLUME
		double milliliter,centimeter3,liter,meter3,inch3,foot3,yard3,gallon,ounce,quart,pint;
		//MASS
		double milligram,gram,kilogram,metricton,grain,ouncem,pound,ton,carat;
		//SPEED
		double msec,mmin,kilomin,kiloh,feetsec,miles,mach,knot;
		//TEMPERATURE
		double kelvin,celsius,fahrenheit,rankie,reaumur;
		//PRESSURE
		double atmos,pascal,hecpascal,kilopascal,bar,millimercury,inchmercury,milliwater,inchwater,kilog2cen,pound2inch;
		public Unit()
		{	
			InitializeComponent();
		}
		void TextBox_DistanceTextChanged(object sender, EventArgs e)
		{}
		void ListBox_DistanceSelectedIndexChanged(object sender, EventArgs e)
		{}
		void ListBox_areaSelectedIndexChanged(object sender, EventArgs e)
		{}
		void TextBox_areaTextChanged(object sender, EventArgs e)
		{}
		void Button_menuClick(object sender, EventArgs e)
		{
			this.Hide();
			MainForm main = new MainForm();
			main.ShowDialog();
			this.Close();
		}

		
		//DISTANCE
		void Button_distanceClick(object sender, EventArgs e)
		{
			flowLayoutPanel_distance.Visible = true;
			flowLayoutPanel_distance.BringToFront();
			//panel1.Visible = true;
		}
		void Button_convertdisClick(object sender, EventArgs e)
		{
			//milli
			if (radioButton_mm.Checked)
			label_distanceshow.Text = radioButton_mm.Text;
			if (radioButton_mm.Checked)
				{
					millimeter = double.Parse(textBox_Distance.Text);
					label_mm.Text = textBox_Distance.Text;
					label1_cm.Text = ((millimeter / 10).ToString());
					label_dm.Text = ((millimeter / 100).ToString());
					label_m.Text = ((millimeter / 1000).ToString());
					label_km.Text = ((millimeter / 1000000).ToString());
					label_in.Text = ((millimeter / 25.4).ToString());
					label_ft.Text = ((millimeter / 304.8).ToString());
					label_yd.Text = ((millimeter / 914.4).ToString());
					label_mi.Text = ((millimeter / 1.609E+6).ToString());
					label_nmi.Text = ((millimeter / 1.852E+6).ToString());
					label_ly.Text = ((millimeter / 9.461e+18).ToString());
				}
			//centi
			if (radioButton_cm.Checked)
			label_distanceshow.Text = radioButton_cm.Text;
			if (radioButton_cm.Checked)
				{
					centimeter = double.Parse(textBox_Distance.Text);
					label1_cm.Text = textBox_Distance.Text;
					label_mm.Text = ((centimeter * 10).ToString());
					label_dm.Text = ((centimeter / 10).ToString());
					label_m.Text = ((centimeter / 100).ToString());
					label_km.Text = ((centimeter / 100000).ToString());
					label_in.Text = ((centimeter / 2.54).ToString());
					label_ft.Text = ((centimeter / 30.48).ToString());
					label_yd.Text = ((centimeter / 91.44).ToString());
					label_mi.Text = ((centimeter / 160934.4).ToString());
					label_nmi.Text = ((centimeter / 185200).ToString());
					label_ly.Text = ((centimeter / 9.461e+17).ToString());
				}
			//deci
			if (radioButton_dm.Checked)
			label_distanceshow.Text = radioButton_dm.Text;
			if (radioButton_dm.Checked)
				{
					decimeter = double.Parse(textBox_Distance.Text);
					label_dm.Text = textBox_Distance.Text;
					label_mm.Text = ((decimeter * 100).ToString());
					label1_cm.Text = ((decimeter * 10).ToString());
					label_m.Text = ((decimeter / 10).ToString());
					label_km.Text = ((decimeter / 10000).ToString());
					label_in.Text = ((decimeter * 3.937).ToString());
					label_yd.Text = ((decimeter / 9.144).ToString());
					label_ft.Text = ((decimeter / 3.048).ToString());
					label_mi.Text = ((decimeter / 16093.44).ToString());
					label_nmi.Text = ((decimeter / 18520).ToString());
					label_ly.Text = ((decimeter / 9.461e+16).ToString());
				}			
			//meter
			if (radioButton_m.Checked)
			label_distanceshow.Text = radioButton_m.Text;
			if (radioButton_m.Checked)
				{
					meter = double.Parse(textBox_Distance.Text);
					label_m.Text = textBox_Distance.Text;
					label_mm.Text = ((meter * 1000).ToString());
					label1_cm.Text = ((meter * 100).ToString());
					label_dm.Text = ((meter * 10).ToString());
					label_km.Text = ((meter / 1000).ToString());
					label_in.Text = ((meter / 0.0254).ToString());
					label_yd.Text = ((meter /0.9144).ToString());
					label_ft.Text = ((meter /0.3048).ToString());
					label_mi.Text = ((meter  /1482).ToString());
					label_nmi.Text = ((meter /1852).ToString());
					label_ly.Text = ((meter /9.461e+15).ToString());
				}			
			//kilo
			if (radioButton_km.Checked)
			label_distanceshow.Text = radioButton_km.Text;
			if (radioButton_km.Checked)
				{
					kilometer = double.Parse(textBox_Distance.Text);
					label_km.Text = textBox_Distance.Text;
					label_mm.Text = ((kilometer * 1e+6).ToString());
					label1_cm.Text = ((kilometer * 100000).ToString());
					label_dm.Text = ((kilometer * 10000).ToString());
					label_m.Text = ((kilometer * 1000).ToString());
					label_in.Text = ((kilometer * 39370.079).ToString());
					label_yd.Text = ((kilometer * 1093.613).ToString());
					label_ft.Text = ((kilometer * 3280.84).ToString());
					label_mi.Text = ((kilometer / 1.609).ToString());
					label_nmi.Text = ((kilometer / 1.852).ToString());
					label_ly.Text = ((kilometer / 9.461e+12).ToString());
				}			
			//inch
			if (radioButton_in.Checked)
			label_distanceshow.Text = radioButton_in.Text;
			if (radioButton_in.Checked)
				{
					inches = double.Parse(textBox_Distance.Text);
					label_in.Text = textBox_Distance.Text;
					label_mm.Text = ((inches * 25.4).ToString());
					label1_cm.Text = ((inches * 2.54).ToString());
					label_dm.Text = ((inches / 3.937).ToString());
					label_m.Text = ((inches / 39.37).ToString());
					label_km.Text = ((inches / 39370.079).ToString());
					label_yd.Text = ((inches / 36).ToString());
					label_ft.Text = ((inches / 12).ToString());
					label_mi.Text = ((inches / 63360).ToString());
					label_nmi.Text = ((inches / 72913.386).ToString());
					label_ly.Text = ((inches / 3.725e+17).ToString());
				}			
			//foot
			if (radioButton_ft.Checked)
			label_distanceshow.Text = radioButton_ft.Text;
			if (radioButton_ft.Checked)
				{
					foot = double.Parse(textBox_Distance.Text);
					label_ft.Text = textBox_Distance.Text;
					label_mm.Text = ((foot * 304.8).ToString());
					label1_cm.Text = ((foot * 30.48).ToString());
					label_dm.Text = ((foot * 3.048).ToString());
					label_m.Text = ((foot / 3.281).ToString());
					label_km.Text = ((foot / 3280.84).ToString());
					label_in.Text = ((foot * 12).ToString());
					label_yd.Text = ((foot / 3).ToString());
					label_mi.Text = ((foot / 5280).ToString());
					label_nmi.Text = ((foot / 6076.115).ToString());
					label_ly.Text = ((foot / 3.104e+16).ToString());
				}			
			//yard
			if (radioButton_yd.Checked)
			label_distanceshow.Text = radioButton_yd.Text;
			if (radioButton_yd.Checked)
				{
					yard = double.Parse(textBox_Distance.Text);
					label_yd.Text = textBox_Distance.Text;
					label_mm.Text = ((yard * 914.4).ToString());
					label1_cm.Text = ((yard * 91.44).ToString());
					label_dm.Text = ((yard * 9.144).ToString());
					label_m.Text = ((yard / 1.094).ToString());
					label_km.Text = ((yard / 1093.613).ToString());
					label_in.Text = ((yard * 36).ToString());
					label_ft.Text = ((yard * 3).ToString());
					label_mi.Text = ((yard / 1760).ToString());
					label_nmi.Text = ((yard / 2025.372).ToString());
					label_ly.Text = ((yard / 1.035e+16).ToString());
				}			
			//mile
			if (radioButton_mile.Checked)
			label_distanceshow.Text = radioButton_mile.Text;
			if (radioButton_mile.Checked)
				{
					mile = double.Parse(textBox_Distance.Text);
					label_mi.Text = textBox_Distance.Text;
					label_mm.Text = ((mile * 1.609e+6).ToString());
					label1_cm.Text = ((mile * 160934.4).ToString());
					label_dm.Text = ((mile * 16093.44).ToString());
					label_m.Text = ((mile * 1609.344).ToString());
					label_km.Text = ((mile * 1.609).ToString());
					label_in.Text = ((mile * 63360).ToString());
					label_ft.Text = ((mile * 5280).ToString());
					label_yd.Text = ((mile * 1760).ToString());
					label_nmi.Text = ((mile / 1.151).ToString());
					label_ly.Text = ((mile / 5.879e+12).ToString());
				}			
			//nmi
			if (radioButton_nmi.Checked)
			label_distanceshow.Text = radioButton_nmi.Text;
			if (radioButton_nmi.Checked)
				{
					nautical = double.Parse(textBox_Distance.Text);
					label_nmi.Text = textBox_Distance.Text;
					label_mm.Text = ((nautical * 1.852e+6).ToString());
					label1_cm.Text = ((nautical * 185200).ToString());
					label_dm.Text = ((nautical * 18520).ToString());
					label_m.Text = ((nautical * 1852).ToString());
					label_km.Text = ((nautical * 1.852).ToString());
					label_in.Text = ((nautical * 72913.386).ToString());
					label_ft.Text = ((nautical * 6076.115).ToString());
					label_yd.Text = ((nautical * 2015.372).ToString());
					label_mi.Text = ((nautical * 1.151).ToString());
					label_ly.Text = ((nautical / 5.108e+12).ToString());
				}			
			//ly
			if (radioButton_ly.Checked)
			label_distanceshow.Text = radioButton_ly.Text;
			if (radioButton_ly.Checked)
				{
				light	= double.Parse(textBox_Distance.Text);
				label_ly.Text = textBox_Distance.Text;
					label_mm.Text = ((light * 9.461e+18).ToString());
					label1_cm.Text = ((light * 9.461e+17).ToString());
					label_dm.Text = ((light * 9.461e+16).ToString());
					label_m.Text = ((light * 9.461e+15).ToString());
					label_km.Text = ((light *  9.461e+12).ToString());
					label_in.Text = ((light * 3.725e+17).ToString());
					label_ft.Text = ((light * 3.104e+16).ToString());
					label_yd.Text = ((light * 1.035e+16).ToString());
					label_mi.Text = ((light * 5.879e+12).ToString());
					label_nmi.Text = ((light * 5.108e+12).ToString());	
			}
		}
		
		
		//AREAS
		void Button_areaClick(object sender, EventArgs e)
		{
			flowLayoutPanel_areas.Visible = true;
			flowLayoutPanel_areas.BringToFront();
		}
		void Button_convertareaClick(object sender, EventArgs e)
		{
			//millimeter2
			if (radioButton_mm2.Checked)
			label_areashow.Text = radioButton_mm2.Text;
			if (radioButton_mm2.Checked)
				{
					millimeter2 = double.Parse(textBox_area.Text);
					label_mm2.Text = textBox_area.Text;
					label_cm2.Text = ((millimeter2 / 100).ToString());
					label_m2.Text = ((millimeter2 / 1e+6).ToString());
					label_a.Text = ((millimeter2 / 1e+8).ToString());
					label_ha.Text = ((millimeter2 / 1e+10).ToString());
					label_km2.Text = ((millimeter2 / 1e+12).ToString());
					label_ft2.Text = ((millimeter2 / 92903.04).ToString());
					label_yd2.Text = ((millimeter2 / 836127.36).ToString());
					label_acre.Text = ((millimeter2 / 4.047e+9).ToString());
				}
			//centimeter2
			if (radioButton_cm2.Checked)
			label_areashow.Text = radioButton_cm2.Text;
			if (radioButton_cm2.Checked)
				{
					centimeter2 = double.Parse(textBox_area.Text);
					label_cm2.Text = textBox_area.Text;
					label_mm2.Text = ((centimeter2 * 100).ToString());
					label_m2.Text = ((centimeter2 / 10000).ToString());
					label_a.Text = ((centimeter2 / 1e+6).ToString());
					label_ha.Text = ((centimeter2 / 1e+8).ToString());
					label_km2.Text = ((centimeter2 / 1e+10).ToString());
					label_ft2.Text = ((centimeter2 / 929.03).ToString());
					label_yd2.Text = ((centimeter2 / 8361.274).ToString());
					label_acre.Text = ((centimeter2 / 4.047e+7).ToString());
				}
			//are
			if (radioButton_a.Checked)
			label_areashow.Text = radioButton_a.Text;
			if (radioButton_a.Checked)
				{
					are = double.Parse(textBox_area.Text);
					label_a.Text = textBox_area.Text;
					label_mm2.Text = ((are * 1e+8).ToString());
					label_cm2.Text = ((are * 1e+6).ToString());
					label_m2.Text = ((are * 100).ToString());
					label_ha.Text = ((are / 100).ToString());
					label_km2.Text = ((are / 10000).ToString());
					label_yd2.Text = ((are * 119.599).ToString());
					label_ft2.Text = ((are * 1076.391).ToString());
					label_acre.Text = ((are / 40.469).ToString());
				}			
			//meter2
			if (radioButton_m2.Checked)
			label_areashow.Text = radioButton_m2.Text;
			if (radioButton_m2.Checked)
				{
					meter2 = double.Parse(textBox_area.Text);
					label_m2.Text = textBox_area.Text;
					label_mm2.Text = ((meter2 * 1e+6).ToString());
					label_cm2.Text = ((meter2 * 10000).ToString());
					label_a.Text = ((meter2 / 100).ToString());
					label_ha.Text = ((meter2 / 10000).ToString());
					label_km2.Text = ((meter2 / 1e+6).ToString());
					label_yd2.Text = ((meter2 * 1.196).ToString());
					label_ft2.Text = ((meter2 * 10.764).ToString());
					label_acre.Text = ((meter2  / 4046.856).ToString());
				}			
			//kilometer2
			if (radioButton_km2.Checked)
			label_areashow.Text = radioButton_km2.Text;
			if (radioButton_km2.Checked)
				{
					kilometer2 = double.Parse(textBox_area.Text);
					label_km2.Text = textBox_area.Text;
					label_mm2.Text = ((kilometer2 * 1e+12).ToString());
					label_cm2.Text = ((kilometer2 * 1e+10).ToString());
					label_m2.Text = ((kilometer2 * 1000).ToString());
					label_a.Text = ((kilometer2 * 10000).ToString());
					label_ha.Text = ((kilometer2 * 100).ToString());
					label_yd2.Text = ((kilometer2 * 1.196e+6).ToString());
					label_ft2.Text = ((kilometer2 * 1.076e+7).ToString());
					label_acre.Text = ((kilometer2 * 247.105).ToString());
				}			
			//hectare
			if (radioButton_ha.Checked)
			label_areashow.Text = radioButton_ha.Text;
			if (radioButton_ha.Checked)
				{
					hectare = double.Parse(textBox_area.Text);
					label_ha.Text = textBox_area.Text;
					label_mm2.Text = ((hectare * 1e+10).ToString());
					label_cm2.Text = ((hectare * 1e+8).ToString());
					label_m2.Text = ((hectare * 10000).ToString());
					label_a.Text = ((hectare * 100).ToString());
					label_km2.Text = ((hectare / 100).ToString());
					label_yd2.Text = ((hectare * 11959.9).ToString());
					label_ft2.Text = ((hectare * 107639.104).ToString());
					label_acre.Text = ((hectare * 2.471).ToString());
				}			
			//foot2
			if (radioButton_ft2.Checked)
			label_areashow.Text = radioButton_ft2.Text;
			if (radioButton_ft2.Checked)
				{
					foot2 = double.Parse(textBox_area.Text);
					label_ft2.Text = textBox_area.Text;
					label_mm2.Text = ((foot2 * 92903.04).ToString());
					label_cm2.Text = ((foot2 * 929.03).ToString());
					label_m2.Text = ((foot2 / 10.764).ToString());
					label_a.Text = ((foot2 / 1076.391).ToString());
					label_ha.Text = ((foot2 / 107639.104).ToString());
					label_km2.Text = ((foot2 / 1.076e+7).ToString());
					label_yd2.Text = ((foot2 / 9).ToString());
					label_acre.Text = ((foot2 / 43560).ToString());
				}			
			//yard2
			if (radioButton_yd2.Checked)
			label_areashow.Text = radioButton_yd2.Text;
			if (radioButton_yd2.Checked)
				{
					yard2 = double.Parse(textBox_area.Text);
					label_yd2.Text = textBox_area.Text;
					label_mm2.Text = ((yard2 * 836127.36).ToString());
					label_cm2.Text = ((yard2 * 8361.274).ToString());
					label_m2.Text = ((yard2 / 1.196).ToString());
					label_a.Text = ((yard2 / 119.599).ToString());
					label_ha.Text = ((yard2 / 11959.9).ToString());
					label_ft2.Text = ((yard2 * 9).ToString());
					label_km2.Text = ((yard2 / 1.196e+6).ToString());
					label_acre.Text = ((yard2 / 4840).ToString());
				}			
			//acre
			if (radioButton_acre.Checked)
			label_areashow.Text = radioButton_acre.Text;
			if (radioButton_acre.Checked)
				{
					acre = double.Parse(textBox_area.Text);
					label_acre.Text = textBox_area.Text;
					label_mm2.Text = ((acre * 4.047e+9).ToString());
					label_cm2.Text = ((acre * 4.047e+7).ToString());
					label_m2.Text = ((acre * 1609.344).ToString());
					label_a.Text = ((acre * 40.469).ToString());
					label_ha.Text = ((acre * 1.609).ToString());
					label_km2.Text = ((acre * 63360).ToString());
					label_ft2.Text = ((acre * 5280).ToString());
					label_yd2.Text = ((acre * 1760).ToString());
				}			
		}
		
		
		//VOLUME
		void Button_volumeClick(object sender, EventArgs e)
		{
			flowLayoutPanel_volume.Visible = true;
			flowLayoutPanel_volume.BringToFront();
		}
		void Button_convertvolClick(object sender, EventArgs e)
		{
			//milliliter
			if (radioButton_ml.Checked)
			label_volumeshow.Text = radioButton_ml.Text;
			if (radioButton_ml.Checked)
				{
					milliliter = double.Parse(textBox_volume.Text);
					label_ml.Text = textBox_volume.Text;
					label_cm3.Text = ((milliliter * 1).ToString());
					label_L.Text = ((milliliter / 1000).ToString());
					label_m3.Text = ((milliliter / 1e+6).ToString());
					label_in3.Text = ((milliliter / 16.387).ToString());
					label_ft3.Text = ((milliliter / 28316.847).ToString());
					label_yd3.Text = ((milliliter / 764554.858).ToString());
					label_gal.Text = ((milliliter / 3785.412).ToString());
					label_oz.Text = ((milliliter / 29.574).ToString());
					label_qt.Text = ((milliliter / 946.353).ToString());
					label_pt.Text = ((milliliter / 473.176).ToString());
				}
			//centimeter3
			if (radioButton_cm3.Checked)
			label_distanceshow.Text = radioButton_cm3.Text;
			if (radioButton_cm3.Checked)
				{
					centimeter3 = double.Parse(textBox_volume.Text);
					label_cm3.Text = textBox_volume.Text;
					label_ml.Text = ((centimeter3 * 1).ToString());
					label_L.Text = ((centimeter3 / 1000).ToString());
					label_m3.Text = ((centimeter3 / 1e+6).ToString());
					label_in3.Text = ((centimeter3 / 16.387).ToString());
					label_ft3.Text = ((centimeter3 / 28316.847).ToString());
					label_yd3.Text = ((centimeter3 / 764554.858).ToString());
					label_gal.Text = ((centimeter3 / 3785.412).ToString());
					label_oz.Text = ((centimeter3 / 29.574).ToString());
					label_qt.Text = ((centimeter3 / 946.353).ToString());
					label_pt.Text = ((centimeter3 / 473.176).ToString());
				}
			//liter
			if (radioButton_L.Checked)
			label_distanceshow.Text = radioButton_L.Text;
			if (radioButton_L.Checked)
				{
					liter = double.Parse(textBox_volume.Text);
					label_L.Text = textBox_volume.Text;
					label_cm3.Text = ((liter * 1000).ToString());
					label_ml.Text = ((liter * 1000).ToString());
					label_m3.Text = ((liter / 1000).ToString());
					label_in3.Text = ((liter * 61.024).ToString());
					label_ft3.Text = ((liter / 28.317).ToString());
					label_yd3.Text = ((liter / 764.555).ToString());
					label_gal.Text = ((liter / 3.785).ToString());
					label_oz.Text = ((liter / 33.814).ToString());
					label_qt.Text = ((liter / 1.057).ToString());
					label_pt.Text = ((liter / 2.113).ToString());
				}			
			//meter3
			if (radioButton_m3.Checked)
			label_distanceshow.Text = radioButton_m3.Text;
			if (radioButton_m3.Checked)
				{
					meter3 = double.Parse(textBox_volume.Text);
					label_m3.Text = textBox_volume.Text;
					label_cm3.Text = ((meter3 * 1000000).ToString());
					label_L.Text = ((meter3 * 1000).ToString());
					label_ml.Text = ((meter3 * 1000000).ToString());
					label_in3.Text = ((meter3 * 61023.744).ToString());
					label_ft3.Text = ((meter3 *35.315 ).ToString());
					label_yd3.Text = ((meter3 *1.308 ).ToString());
					label_gal.Text = ((meter3 *264.172 ).ToString());
					label_oz.Text = ((meter3 *33814.023 ).ToString());
					label_qt.Text = ((meter3 *1056.688 ).ToString());
					label_pt.Text = ((meter3 *2113.376 ).ToString());
				}			
			//inch3
			if (radioButton_in3.Checked)
			label_distanceshow.Text = radioButton_in3.Text;
			if (radioButton_in3.Checked)
				{
					inch3 = double.Parse(textBox_volume.Text);
					label_in3.Text = textBox_volume.Text;
					label_cm3.Text = ((inch3 *16.387).ToString());
					label_L.Text = ((inch3 /61.024).ToString());
					label_m3.Text = ((inch3 /61023.744).ToString());
					label_ml.Text = ((inch3 *16.387).ToString());
					label_ft3.Text = ((inch3 /1728).ToString());
					label_yd3.Text = ((inch3 /46656).ToString());
					label_gal.Text = ((inch3 /231).ToString());
					label_oz.Text = ((inch3 /1.805).ToString());
					label_qt.Text = ((inch3 /57.75).ToString());
					label_pt.Text = ((inch3 /28.875).ToString());
				}			
			//foot3
			if (radioButton_ft3.Checked)
			label_distanceshow.Text = radioButton_ft3.Text;
			if (radioButton_ft3.Checked)
				{
					foot3 = double.Parse(textBox_volume.Text);
					label_ft3.Text = textBox_volume.Text;
					label_cm3.Text = ((foot3 *28316.847).ToString());
					label_L.Text = ((foot3 *28.317).ToString());
					label_m3.Text = ((foot3 /35.315).ToString());
					label_in3.Text = ((foot3 *1728).ToString());
					label_ml.Text = ((foot3 *28316.847).ToString());
					label_yd3.Text = ((foot3 /27).ToString());
					label_gal.Text = ((foot3 *7.481).ToString());
					label_oz.Text = ((foot3 *957.506).ToString());
					label_qt.Text = ((foot3 *29.922).ToString());
					label_pt.Text = ((foot3 *59.844).ToString());
				}			
			//yard3
			if (radioButton_yd3.Checked)
			label_distanceshow.Text = radioButton_yd3.Text;
			if (radioButton_yd3.Checked)
				{
					yard3 = double.Parse(textBox_volume.Text);
					label_yd3.Text = textBox_volume.Text;
					label_cm3.Text = ((yard3 *764554.858).ToString());
					label_L.Text = ((yard3 *764.555).ToString());
					label_m3.Text = ((yard3 /1.308).ToString());
					label_in3.Text = ((yard3 *46656).ToString());
					label_ft3.Text = ((yard3 *27).ToString());
					label_ml.Text = ((yard3 *764554.858).ToString());
					label_gal.Text = ((yard3 *201.974).ToString());
					label_oz.Text = ((yard3 *25852.675).ToString());
					label_qt.Text = ((yard3 *807.896).ToString());
					label_pt.Text = ((yard3 *1615.792).ToString());
				}			
			//gallon
			if (radioButton_gal.Checked)
			label_distanceshow.Text = radioButton_gal.Text;
			if (radioButton_gal.Checked)
				{
					gallon = double.Parse(textBox_volume.Text);
					label_gal.Text = textBox_volume.Text;
					label_cm3.Text = ((gallon *3785.412).ToString());
					label_L.Text = ((gallon *3.785).ToString());
					label_m3.Text = ((gallon /264.172).ToString());
					label_in3.Text = ((gallon *231).ToString());
					label_ft3.Text = ((gallon /7.481).ToString());
					label_yd3.Text = ((gallon /201.974).ToString());
					label_ml.Text = ((gallon *3785.412).ToString());
					label_oz.Text = ((gallon *128).ToString());
					label_qt.Text = ((gallon *4).ToString());
					label_pt.Text = ((gallon *8).ToString());
				}			
			//ounce
			if (radioButton_oz.Checked)
			label_distanceshow.Text = radioButton_oz.Text;
			if (radioButton_oz.Checked)
				{
					ounce = double.Parse(textBox_volume.Text);
					label_oz.Text = textBox_volume.Text;
					label_cm3.Text = ((ounce *29.574).ToString());
					label_L.Text = ((ounce /33.814).ToString());
					label_m3.Text = ((ounce /33814.023).ToString());
					label_in3.Text = ((ounce *1.805).ToString());
					label_ft3.Text = ((ounce /957.506).ToString());
					label_yd3.Text = ((ounce /25852.675).ToString());
					label_gal.Text = ((ounce /128).ToString());
					label_ml.Text = ((ounce *29.574).ToString());
					label_qt.Text = ((ounce /32).ToString());
					label_pt.Text = ((ounce /16).ToString());
				}			
			//quart
			if (radioButton_qt.Checked)
			label_distanceshow.Text = radioButton_qt.Text;
			if (radioButton_qt.Checked)
				{
					quart = double.Parse(textBox_volume.Text);
					label_qt.Text = textBox_volume.Text;
					label_cm3.Text = ((quart *946.353).ToString());
					label_L.Text = ((quart /1.057).ToString());
					label_m3.Text = ((quart /1056.688).ToString());
					label_in3.Text = ((quart *57.75).ToString());
					label_ft3.Text = ((quart /29.922).ToString());
					label_yd3.Text = ((quart /807.896).ToString());
					label_gal.Text = ((quart /4).ToString());
					label_oz.Text = ((quart *32).ToString());
					label_ml.Text = ((quart *946.353).ToString());
					label_pt.Text = ((quart *2).ToString());
				}			
			//pint
			if (radioButton_pt.Checked)
			label_distanceshow.Text = radioButton_pt.Text;
			if (radioButton_pt.Checked)
				{
					pint = double.Parse(textBox_volume.Text);
					label_pt.Text = textBox_volume.Text;
					label_cm3.Text = ((pint *473.176).ToString());
					label_L.Text = ((pint /2.113).ToString());
					label_m3.Text = ((pint /2113.376).ToString());
					label_in3.Text = ((pint *28.875).ToString());
					label_ft3.Text = ((pint /59.844).ToString());
					label_yd3.Text = ((pint /1615.792).ToString());
					label_gal.Text = ((pint /8).ToString());
					label_oz.Text = ((pint *16).ToString());
					label_qt.Text = ((pint /2).ToString());
					label_ml.Text = ((pint *473.176).ToString());
				}
		}
		
		
		//MASS
		void Button_massClick(object sender, EventArgs e)
		{
			flowLayoutPanel_mass.Visible = true;
			flowLayoutPanel_mass.BringToFront();
		}
		void Button_convertmassClick(object sender, EventArgs e)
		{
			//milligram
			if (radioButton_mg.Checked)
			label_massshow.Text = radioButton_mg.Text;
			if (radioButton_mg.Checked)
				{
					milligram = double.Parse(textBox_mass.Text);
					label_mg.Text = textBox_mass.Text;
					label_g.Text = ((milligram/1000).ToString());
					label_kg.Text = ((milligram/1.0e+6).ToString());
					label_t.Text = ((milligram/1e+9).ToString());
					label_gr.Text = ((milligram/64.799).ToString());
					label_ozm.Text = ((milligram/28349.523).ToString());
					label_lb.Text = ((milligram/453592.37).ToString());
					label_ton.Text = ((milligram/9.072e+8).ToString());
					label_ct.Text = ((milligram/200).ToString());
				}
			//gram
			if (radioButton_g.Checked)
			label_massshow.Text = radioButton_g.Text;
			if (radioButton_g.Checked)
				{
					gram = double.Parse(textBox_mass.Text);
					label_g.Text = textBox_mass.Text;
					label_mg.Text = ((gram*1000).ToString());
					label_kg.Text = ((gram/1000).ToString());
					label_t.Text = ((gram/1e+6).ToString());
					label_gr.Text = ((gram*15.432).ToString());
					label_ozm.Text = ((gram/28.35).ToString());
					label_lb.Text = ((gram/453.592).ToString());
					label_ton.Text = ((gram/907184.74).ToString());
					label_ct.Text = ((gram*5).ToString());
				}
			//kilogram
			if (radioButton_kg.Checked)
			label_massshow.Text = radioButton_kg.Text;
			if (radioButton_kg.Checked)
				{
					kilogram = double.Parse(textBox_mass.Text);
					label_kg.Text = textBox_mass.Text;
					label_g.Text = ((kilogram*1000).ToString());
					label_mg.Text = ((kilogram*1e+6).ToString());
					label_t.Text = ((kilogram/1000).ToString());
					label_gr.Text = ((kilogram*15432.358).ToString());
					label_ozm.Text = ((kilogram*35.274).ToString());
					label_lb.Text = ((kilogram*2.205).ToString());
					label_ton.Text = ((kilogram/907.185).ToString());
					label_ct.Text = ((kilogram*5000).ToString());
				}			
			//metricton
			if (radioButton_t.Checked)
			label_massshow.Text = radioButton_t.Text;
			if (radioButton_t.Checked)
				{
					metricton = double.Parse(textBox_mass.Text);
					label_t.Text = textBox_mass.Text;
					label_g.Text = ((metricton*1e+6).ToString());
					label_kg.Text = ((metricton*1000).ToString());
					label_mg.Text = ((metricton*1e+9).ToString());
					label_gr.Text = ((metricton*1.543e+7).ToString());
					label_ozm.Text = ((metricton*35273.962).ToString());
					label_lb.Text = ((metricton*2204.623).ToString());
					label_ton.Text = ((metricton*1.102).ToString());
					label_ct.Text = ((metricton*5e+6).ToString());
				}			
			//grain
			if (radioButton_gr.Checked)
			label_massshow.Text = radioButton_gr.Text;
			if (radioButton_gr.Checked)
				{
				grain = double.Parse(textBox_mass.Text);
					label_gr.Text = textBox_mass.Text;
					label_g.Text = ((grain/15.432).ToString());
					label_kg.Text = ((grain/15432.358).ToString());
					label_t.Text = ((grain/1.543e+7).ToString());
					label_mg.Text = ((grain*64.799).ToString());
					label_ozm.Text = ((grain/437.5).ToString());
					label_lb.Text = ((grain/7000).ToString());
					label_ton.Text = ((grain/1.4e+7).ToString());
					label_ct.Text = ((grain/3.086).ToString());
				}			
			//ouncem
			if (radioButton_ozm.Checked)
			label_massshow.Text = radioButton_ozm.Text;
			if (radioButton_ozm.Checked)
				{
					ouncem = double.Parse(textBox_mass.Text);
					label_ozm.Text = textBox_mass.Text;
					label_g.Text = ((ouncem*28.35).ToString());
					label_kg.Text = ((ouncem/35.274).ToString());
					label_t.Text = ((ouncem/35273.962).ToString());
					label_gr.Text = ((ouncem*437.5).ToString());
					label_mg.Text = ((ouncem*28349.523).ToString());
					label_lb.Text = ((ouncem/16).ToString());
					label_ton.Text = ((ouncem/32000).ToString());
					label_ct.Text = ((ouncem*141.748).ToString());
				}			
			//pound
			if (radioButton_lb.Checked)
			label_massshow.Text = radioButton_lb.Text;
			if (radioButton_lb.Checked)
				{
					pound = double.Parse(textBox_mass.Text);
					label_lb.Text = textBox_mass.Text;
					label_g.Text = ((pound*453.592).ToString());
					label_kg.Text = ((pound/2.205).ToString());
					label_t.Text = ((pound/2204.623).ToString());
					label_gr.Text = ((pound*7000).ToString());
					label_ozm.Text = ((pound*16).ToString());
					label_mg.Text = ((pound*453592.37).ToString());
					label_ton.Text = ((pound/2000).ToString());
					label_ct.Text = ((pound*2267.962).ToString());
				}			
			//ton
			if (radioButton_ton.Checked)
			label_massshow.Text = radioButton_ton.Text;
			if (radioButton_ton.Checked)
				{
					ton = double.Parse(textBox_mass.Text);
					label_ton.Text = textBox_mass.Text;
					label_g.Text = ((ton*907184.74).ToString());
					label_kg.Text = ((ton*907.185).ToString());
					label_t.Text = ((ton/1.102).ToString());
					label_gr.Text = ((ton*1.4e+7).ToString());
					label_ozm.Text = ((ton*32000).ToString());
					label_lb.Text = ((ton*2000).ToString());
					label_mg.Text = ((ton*9.072e+8).ToString());
					label_ct.Text = ((ton*4.536e+6).ToString());
				}			
			//carat
			if (radioButton_ct.Checked)
			label_massshow.Text = radioButton_ct.Text;
			if (radioButton_ct.Checked)
				{
					carat = double.Parse(textBox_mass.Text);
					label_ct.Text = textBox_mass.Text;
					label_g.Text = ((carat/5).ToString());
					label_kg.Text = ((carat/5000).ToString());
					label_t.Text = ((carat/5e+6).ToString());
					label_gr.Text = ((carat*3.086).ToString());
					label_ozm.Text = ((carat/141.748).ToString());
					label_lb.Text = ((carat/2267.962).ToString());
					label_ton.Text = ((carat/4.536e+6).ToString());
					label_mg.Text = ((carat*200).ToString());
				}
		}
		
		
		//SPEED
		void Button_speedClick(object sender, EventArgs e)
		{
			flowLayoutPanel_speed.Visible = true;
			flowLayoutPanel_speed.BringToFront();
		}
		void Button_convertspeedClick(object sender, EventArgs e)
		{
			//msec
			if (radioButton_ms.Checked)
			label_speedshow.Text = radioButton_ms.Text;
			if (radioButton_ms.Checked)
				{
					msec = double.Parse(textBox_speed.Text);
					label_ms.Text = textBox_speed.Text;
					label_mmin.Text = ((msec*60).ToString());
					label_kmmin.Text = ((msec/16.667).ToString());
					label_kmh.Text = ((msec*3.6).ToString());
					label_fts.Text = ((msec*3.281).ToString());
					label_mph.Text = ((msec*2.237).ToString());
					label_mach.Text = ((msec/343).ToString());
					label_kn.Text = ((msec*1.944).ToString());
				}
			//mmin
			if (radioButton_mmin.Checked)
			label_speedshow.Text = radioButton_mmin.Text;
			if (radioButton_mmin.Checked)
				{
					mmin = double.Parse(textBox_speed.Text);
					label_mmin.Text = textBox_speed.Text;
					label_ms.Text = ((mmin/60).ToString());
					label_kmmin.Text = ((mmin/1000).ToString());
					label_kmh.Text = ((mmin/16.667).ToString());
					label_fts.Text = ((mmin/18.288).ToString());
					label_mph.Text = ((mmin/26.822).ToString());
					label_mach.Text = ((mmin*20580).ToString());
					label_kn.Text = ((mmin/30.867).ToString());
				}
			//kilomin
			if (radioButton_kmmin.Checked)
			label_speedshow.Text = radioButton_kmmin.Text;
			if (radioButton_kmmin.Checked)
				{
					kilomin = double.Parse(textBox_speed.Text);
					label_kmmin.Text = textBox_speed.Text;
					label_mmin.Text = ((kilomin*1000).ToString());
					label_ms.Text = ((kilomin*16.667).ToString());
					label_kmh.Text = ((kilomin*60).ToString());
					label_fts.Text = ((kilomin*54.681).ToString());
					label_mph.Text = ((kilomin*37.282).ToString());
					label_mach.Text = ((kilomin/20.58).ToString());
					label_kn.Text = ((kilomin*32.397).ToString());
				}			
			//kiloh
			if (radioButton_kmh.Checked)
			label_speedshow.Text = radioButton_kmh.Text;
			if (radioButton_kmh.Checked)
				{
					kiloh = double.Parse(textBox_speed.Text);
					label_kmh.Text = textBox_speed.Text;
					label_mmin.Text = ((kiloh*16.667).ToString());
					label_kmmin.Text = ((kiloh/60).ToString());
					label_ms.Text = ((kiloh/3.6).ToString());
					label_fts.Text = ((kiloh/1.097).ToString());
					label_mph.Text = ((kiloh/1.609).ToString());
					label_mach.Text = ((kiloh/1234.8).ToString());
					label_kn.Text = ((kiloh/1.852).ToString());
				}			
			//feetsec
			if (radioButton_fts.Checked)
			label_speedshow.Text = radioButton_fts.Text;
			if (radioButton_fts.Checked)
				{
					feetsec = double.Parse(textBox_speed.Text);
					label_fts.Text = textBox_speed.Text;
					label_mmin.Text = ((feetsec*18.288).ToString());
					label_kmmin.Text = ((feetsec/54.681).ToString());
					label_kmh.Text = ((feetsec*1.097).ToString());
					label_ms.Text = ((feetsec/3.281).ToString());
					label_mph.Text = ((feetsec/1.467).ToString());
					label_mach.Text = ((feetsec/1125.328).ToString());
					label_kn.Text = ((feetsec/1.688).ToString());
				}			
			//miles
			if (radioButton_mph.Checked)
			label_speedshow.Text = radioButton_mph.Text;
			if (radioButton_mph.Checked)
				{
					miles = double.Parse(textBox_speed.Text);
					label_mph.Text = textBox_speed.Text;
					label_mmin.Text = ((miles*26.822).ToString());
					label_kmmin.Text = ((miles/37.282).ToString());
					label_kmh.Text = ((miles*1.609).ToString());
					label_fts.Text = ((miles*1.467).ToString());
					label_ms.Text = ((miles/2.237).ToString());
					label_mach.Text = ((miles/767.269).ToString());
					label_kn.Text = ((miles/1.151).ToString());
				}			
			//mach
			if (radioButton_mach.Checked)
			label_speedshow.Text = radioButton_mach.Text;
			if (radioButton_mach.Checked)
				{
					mach = double.Parse(textBox_speed.Text);
					label_mach.Text = textBox_speed.Text;
					label_mmin.Text = ((mach*20580).ToString());
					label_kmmin.Text = ((mach*20.58).ToString());
					label_kmh.Text = ((mach*1234.8).ToString());
					label_fts.Text = ((mach*1125.328).ToString());
					label_mph.Text = ((mach*767.269).ToString());
					label_ms.Text = ((mach*343).ToString());
					label_kn.Text = ((mach*666.739).ToString());
				}			
			//knot
			if (radioButton_kn.Checked)
			label_speedshow.Text = radioButton_kn.Text;
			if (radioButton_kn.Checked)
				{
					knot = double.Parse(textBox_speed.Text);
					label_kn.Text = textBox_speed.Text;
					label_mmin.Text = ((knot*30.867).ToString());
					label_kmmin.Text = ((knot/32.397).ToString());
					label_kmh.Text = ((knot*1.852).ToString());
					label_fts.Text = ((knot*1.688).ToString());
					label_mph.Text = ((knot*1.151).ToString());
					label_mach.Text = ((knot/666.739).ToString());
					label_ms.Text = ((knot/1.944).ToString());
				}			
		}
		
		
		//TEMPERATURE
		void Button_temperatureClick(object sender, EventArgs e)
		{
			flowLayoutPanel_temperature.Visible = true;
			flowLayoutPanel_temperature.BringToFront();
		}
		void Button_converttempClick(object sender, EventArgs e)
		{
			//kelvin
			if (radioButton_K.Checked)
			label_tempshow.Text = radioButton_K.Text;
			if (radioButton_K.Checked)
				{
					kelvin = double.Parse(textBox_temp.Text);
					label_K.Text = textBox_temp.Text;
					label_C.Text = ((kelvin - 273.15).ToString());
					label_F.Text = (((kelvin - 273.15) * 9/5 + 32).ToString());
					label_R.Text = ((kelvin*1.8).ToString());
					label_Re.Text = (((kelvin - 273.15)*0.8).ToString());
				}
			//celsius
			if (radioButton_C.Checked)
			label_tempshow.Text = radioButton_C.Text;
			if (radioButton_C.Checked)
				{
					celsius = double.Parse(textBox_temp.Text);
					label_C.Text = textBox_temp.Text;
					label_K.Text = ((celsius + 273.15).ToString());
					label_F.Text = (((celsius * 9/5) + 32).ToString());
					label_R.Text = ((celsius * 9/5 + 491.67).ToString());
					label_Re.Text = ((celsius*0.8).ToString());
				}
			//fahrenheit
			if (radioButton_F.Checked)
			label_tempshow.Text = radioButton_F.Text;
			if (radioButton_F.Checked)
				{
					fahrenheit = double.Parse(textBox_temp.Text);
					label_F.Text = textBox_temp.Text;
					label_C.Text = (((fahrenheit - 32) * 5/9).ToString());
					label_K.Text = (((fahrenheit - 32) * 5/9 + 273.15).ToString());
					label_R.Text = ((fahrenheit + 459.67).ToString());
					label_Re.Text = (((fahrenheit - 32) / 2.25).ToString());
				}			
			//rankie
			if (radioButton_R.Checked)
			label_tempshow.Text = radioButton_R.Text;
			if (radioButton_R.Checked)
				{
					rankie = double.Parse(textBox_temp.Text);
					label_R.Text = textBox_temp.Text;
					label_C.Text = (((rankie - 491.67) * 5/9).ToString());
					label_F.Text = ((rankie - 459.67).ToString());
					label_K.Text = ((rankie * 5/9).ToString());
					label_Re.Text = (((rankie- 32 - 459.67) / 2.25).ToString());
				}			
			//reaumur
			if (radioButton_Re.Checked)
			label_tempshow.Text = radioButton_Re.Text;
			if (radioButton_Re.Checked)
				{
					reaumur = double.Parse(textBox_temp.Text);
					label_Re.Text = textBox_temp.Text;
					label_C.Text = ((reaumur*1.25).ToString());
					label_F.Text = ((reaumur*2.25 + 32).ToString());
					label_R.Text = ((reaumur*2.25 + 32 + 459.67).ToString());
					label_K.Text = ((reaumur*1.25 + 273.15).ToString());
				}					
		}
		
		
		//PRESSURE
		void Button_pressureClick(object sender, EventArgs e)
		{
			flowLayoutPanel_pressure.Visible = true;
			flowLayoutPanel_pressure.BringToFront();
		}
		void Button_convertpressClick(object sender, EventArgs e)
		{
			//atmos
			if (radioButton_atm.Checked)
			label_pressshow.Text = radioButton_atm.Text;
			if (radioButton_atm.Checked)
				{
					atmos = double.Parse(textBox_press.Text);
					label_atm.Text = textBox_press.Text;
					label_Pa.Text = ((atmos*1.01295).ToString());
					label_hPa.Text = ((atmos*1013.25).ToString());
					label_kPa.Text = ((atmos*101.325).ToString());
					label_bar.Text = ((atmos*1.01295).ToString());
					label_mmHg.Text = ((atmos*760).ToString());
					label_inHg.Text = ((atmos*29.9213).ToString());
					label_mmWg.Text = ((atmos*10339.2857).ToString());
					label_inWg.Text = ((atmos*406.86).ToString());
					label_kgf.Text = ((atmos*1.03325).ToString());
					label_psi.Text = ((atmos*14.696).ToString());
				}
			//pascal
			if (radioButton_Pa.Checked)
			label_pressshow.Text = radioButton_Pa.Text;
			if (radioButton_Pa.Checked)
				{
					pascal = double.Parse(textBox_press.Text);
					label_Pa.Text = textBox_press.Text;
					label_atm.Text = ((pascal*9.869).ToString());
					label_hPa.Text = ((pascal/100).ToString());
					label_kPa.Text = ((pascal/1000).ToString());
					label_bar.Text = ((pascal*100000).ToString());
					label_mmHg.Text = ((pascal*7.5028).ToString());
					label_inHg.Text = ((pascal*2.954).ToString());
					label_mmWg.Text = ((pascal*0.102040816326531).ToString());
					label_inWg.Text = ((pascal*4.018 ).ToString());
					label_kgf.Text = ((pascal*1.020).ToString());
					label_psi.Text = ((pascal*1.4508 ).ToString());
				}
			//hecpascal
			if (radioButton_hPa.Checked)
			label_pressshow.Text = radioButton_hPa.Text;
			if (radioButton_hPa.Checked)
				{
					hecpascal = double.Parse(textBox_press.Text);
					label_hPa.Text = textBox_press.Text;
					label_Pa.Text = ((hecpascal*100).ToString());
					label_atm.Text = ((hecpascal/1013.25).ToString());
					label_kPa.Text = ((hecpascal/10).ToString());
					label_bar.Text = ((hecpascal/1000).ToString());
					label_mmHg.Text = ((hecpascal/1.333).ToString());
					label_inHg.Text = ((hecpascal/33.864).ToString());
					label_mmWg.Text = ((hecpascal*0.10204081).ToString());
					label_inWg.Text = ((hecpascal/2.488).ToString());
					label_kgf.Text = ((hecpascal/980.665).ToString());
					label_psi.Text = ((hecpascal/68.948).ToString());
				}			
			//kilopascal
			if (radioButton_kPa.Checked)
			label_pressshow.Text = radioButton_kPa.Text;
			if (radioButton_kPa.Checked)
				{
					kilopascal = double.Parse(textBox_press.Text);
					label_kPa.Text = textBox_press.Text;
					label_Pa.Text = ((kilopascal*1000).ToString());
					label_hPa.Text = ((kilopascal*10).ToString());
					label_atm.Text = ((kilopascal/101.325).ToString());
					label_bar.Text = ((kilopascal/100).ToString());
					label_mmHg.Text = ((kilopascal*7.501).ToString());
					label_inHg.Text = ((kilopascal/3.386).ToString());
					label_mmWg.Text = ((kilopascal* 0.00980665).ToString());
					label_inWg.Text = ((kilopascal*4.019).ToString());
					label_kgf.Text = ((kilopascal/98.066).ToString());
					label_psi.Text = ((kilopascal/6.895).ToString());
				}		
			//bar
			if (radioButton_bar.Checked)
			label_pressshow.Text = radioButton_bar.Text;
			if (radioButton_bar.Checked)
				{
					bar = double.Parse(textBox_press.Text);
					label_bar.Text = textBox_press.Text;
					label_Pa.Text = ((bar*1).ToString());
					label_hPa.Text = ((bar*1000).ToString());
					label_kPa.Text = ((bar*100).ToString());
					label_atm.Text = ((bar*0.9872).ToString());
					label_mmHg.Text = ((bar*750.2838).ToString());
					label_inHg.Text = ((bar*29.54).ToString());
					label_mmWg.Text = ((bar*10.197162129779).ToString());
					label_inWg.Text = ((bar*401.65).ToString());
					label_kgf.Text = ((bar*1.02).ToString());
					label_psi.Text = ((bar*14.508).ToString());
				}		
			//millimercury
			if (radioButton_mmHg.Checked)
			label_pressshow.Text = radioButton_mmHg.Text;
			if (radioButton_mmHg.Checked)
				{
					millimercury = double.Parse(textBox_press.Text);
					label_mmHg.Text = textBox_press.Text;
					label_Pa.Text = ((millimercury*133.28).ToString());
					label_hPa.Text = ((millimercury*1.333).ToString());
					label_kPa.Text = ((millimercury/7.501).ToString());
					label_bar.Text = ((millimercury*1.3328).ToString());
					label_atm.Text = ((millimercury*1.3158).ToString());
					label_inHg.Text = ((millimercury*3.937).ToString());
					label_mmWg.Text = ((millimercury*0.073555913527668).ToString());
					label_inWg.Text = ((millimercury*0.5353).ToString());
					label_kgf.Text = ((millimercury*1.3595).ToString());
					label_psi.Text = ((millimercury*1.934).ToString());
				}		
			//inchmercury
			if (radioButton_inHg.Checked)
			label_pressshow.Text = radioButton_inHg.Text;
			if (radioButton_inHg.Checked)
				{
					inchmercury = double.Parse(textBox_press.Text);
					label_inHg.Text = textBox_press.Text;
					label_Pa.Text = ((inchmercury*3385).ToString());
					label_hPa.Text = ((inchmercury*33.864).ToString());
					label_kPa.Text = ((inchmercury*3.386).ToString());
					label_bar.Text = ((inchmercury*3.385 ).ToString());
					label_mmHg.Text = ((inchmercury*25.4).ToString());
					label_atm.Text = ((inchmercury*3.342 ).ToString());
					label_mmWg.Text = ((inchmercury*0.00029529983071445).ToString());
					label_inWg.Text = ((inchmercury*13.598).ToString());
					label_kgf.Text = ((inchmercury*3.4532 ).ToString());
					label_psi.Text = ((inchmercury*0.4912).ToString());
				}			
			//milliwater
			if (radioButton_mmWg.Checked)
			label_pressshow.Text = radioButton_mmWg.Text;
			if (radioButton_mmWg.Checked)
				{
					milliwater = double.Parse(textBox_press.Text);
					label_mmWg.Text = textBox_press.Text;
					label_Pa.Text = ((milliwater).ToString());
					label_hPa.Text = ((milliwater).ToString());
					label_kPa.Text = ((milliwater).ToString());
					label_bar.Text = ((milliwater).ToString());
					label_mmHg.Text = ((milliwater).ToString());
					label_inHg.Text = ((milliwater).ToString());
					label_atm.Text = ((milliwater).ToString());
					label_inWg.Text = ((milliwater).ToString());
					label_kgf.Text = ((milliwater).ToString());
					label_psi.Text = ((milliwater).ToString());
				}
			//inchwater
			if (radioButton_inWg.Checked)
			label_pressshow.Text = radioButton_inWg.Text;
			if (radioButton_inWg.Checked)
				{
					inchwater = double.Parse(textBox_press.Text);
					label_inWg.Text = textBox_press.Text;
					label_Pa.Text = ((inchwater*248.9 ).ToString());
					label_hPa.Text = ((inchwater*2.488).ToString());
					label_kPa.Text = ((inchwater/4.019).ToString());
					label_bar.Text = ((inchwater*2.489 ).ToString());
					label_mmHg.Text = ((inchwater*1.868).ToString());
					label_inHg.Text = ((inchwater*7.354).ToString());
					label_mmWg.Text = ((inchwater*25.399999830047).ToString());
					label_atm.Text = ((inchwater*2.458).ToString());
					label_kgf.Text = ((inchwater*2.5396 ).ToString());
					label_psi.Text = ((inchwater*3.612 ).ToString());
				}
			//kilog2cen
			if (radioButton_kgf.Checked)
			label_pressshow.Text = radioButton_kgf.Text;
			if (radioButton_kgf.Checked)
				{
					kilog2cen = double.Parse(textBox_press.Text);
					label_kgf.Text = textBox_press.Text;
					label_Pa.Text = ((kilog2cen*9.804).ToString());
					label_hPa.Text = ((kilog2cen*980.665).ToString());
					label_kPa.Text = ((kilog2cen*98.066).ToString());
					label_bar.Text = ((kilog2cen*0.9804).ToString());
					label_mmHg.Text = ((kilog2cen*7.3554).ToString());
					label_inHg.Text = ((kilog2cen*28.958).ToString());
					label_mmWg.Text = ((kilog2cen*0.0001).ToString());
					label_inWg.Text = ((kilog2cen*393.76).ToString());
					label_atm.Text = ((kilog2cen*0.9678).ToString());
					label_psi.Text = ((kilog2cen*14.223).ToString());
				}
			//pound2inch
			if (radioButton_psi.Checked)
			label_pressshow.Text = radioButton_psi.Text;
			if (radioButton_psi.Checked)
				{
					pound2inch = double.Parse(textBox_press.Text);
					label_psi.Text = textBox_press.Text;
					label_Pa.Text = ((pound2inch*6.8927).ToString());
					label_hPa.Text = ((pound2inch*68.948).ToString());
					label_kPa.Text = ((pound2inch*6.895).ToString());
					label_bar.Text = ((pound2inch*0.06893).ToString());
					label_mmHg.Text = ((pound2inch*51.71).ToString());
					label_inHg.Text = ((pound2inch*2.036).ToString());
					label_mmWg.Text = ((pound2inch*0.0014223343334285).ToString());
					label_inWg.Text = ((pound2inch*27.68).ToString());
					label_kgf.Text = ((pound2inch*7.0309 ).ToString());
					label_atm.Text = ((pound2inch*0.06805).ToString());
				}		
		}

	}
}