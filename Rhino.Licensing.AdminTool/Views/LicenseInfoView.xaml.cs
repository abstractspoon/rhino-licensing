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

			this.Plugin.Items.Add("00000000-0000-0000-0000-000000000000:All Components");

			this.Plugin.Items.Add("4CBCF4EA-7B02-41E1-BE65-3E03025E1FFE:UIExtension.Week Planner");
			this.Plugin.Items.Add("14FC02B5-2DE0-4A2F-BA6A-50A66551864E:UIExtension.Mind Map");
			this.Plugin.Items.Add("3BDEF4EA-7B02-41E1-BE65-3E03025E1FFE:UIExtension.Word Cloud");

			this.Plugin.Items.Add("49A52D2D-7661-49AF-949A-E60066B300FC:Exporter.Markdown");
			this.Plugin.Items.Add("85D6AC7D-2D7D-4ACE-B776-C215FA181C33:Exporter.Outlook");
			this.Plugin.Items.Add("95E6E2D4-2301-461A-80FB-C2863E788F37:Exporter.HTML Reporter");

			this.Plugin.Items.Add("FE0B6B6E-2B61-4AEB-AA0D-98DBE5942F02:Comments.HTML");
			this.Plugin.Items.Add("BAA4E079-268B-4B9B-B7C8-6D15CCF058A2:Comments.Markdown");

			// Remove license types we don't use
//			this.LicenseType.Items.Remove(Rhino.Licensing.LicenseType.Floating);
		}
	}
}

