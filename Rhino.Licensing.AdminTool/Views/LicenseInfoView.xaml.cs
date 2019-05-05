using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rhino.Licensing.AdminTool.Views
{
    /// <summary>
    /// Interaction logic for LicenseInfoView.xaml
    /// </summary>
    public partial class LicenseInfoView : UserControl
    {
        public LicenseInfoView()
        {
            InitializeComponent();

			this.Plugin.DisplayMemberPath = "Key";
			this.Plugin.SelectedValuePath = "Value";

			this.Plugin.Items.Add(new KeyValuePair<string, string>("All Components", "00000000-0000-0000-0000-000000000000"));

			this.Plugin.Items.Add(new KeyValuePair<string, string>("UIExtension.Week Planner", "4CBCF4EA-7B02-41E1-BE65-3E03025E1FFE"));
			this.Plugin.Items.Add(new KeyValuePair<string, string>("UIExtension.Mind Map", "14FC02B5-2DE0-4A2F-BA6A-50A66551864E"));
			this.Plugin.Items.Add(new KeyValuePair<string, string>("UIExtension.Word Cloud", "3BDEF4EA-7B02-41E1-BE65-3E03025E1FFE"));
			this.Plugin.Items.Add(new KeyValuePair<string, string>("Exporter.Markdown", "49A52D2D-7661-49AF-949A-E60066B300FC"));
			this.Plugin.Items.Add(new KeyValuePair<string, string>("Exporter.Outlook", "85D6AC7D-2D7D-4ACE-B776-C215FA181C33"));
			this.Plugin.Items.Add(new KeyValuePair<string, string>("Exporter.HTML Reporter", "95E6E2D4-2301-461A-80FB-C2863E788F37"));
			this.Plugin.Items.Add(new KeyValuePair<string, string>("Comments.HTML", "FE0B6B6E-2B61-4AEB-AA0D-98DBE5942F02"));
			this.Plugin.Items.Add(new KeyValuePair<string, string>("Comments.Markdown", "BAA4E079-268B-4B9B-B7C8-6D15CCF058A2"));

			// Remove license types we don't use
//			this.LicenseType.Items.Remove(Rhino.Licensing.LicenseType.Floating);
		}
	}
}

