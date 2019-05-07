using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Caliburn.PresentationFramework;

namespace Rhino.Licensing.AdminTool.Model
{
    [DataContract(Name = "License", Namespace = "http://schemas.hibernatingrhinos.com/")]
    public class License : PropertyChangedBase
    {
        private ObservableCollection<UserData> _data;
        private string _ownerId;
		private string _plugin;
		private DateTime? _expirationDate;
        private LicenseType _licenseType;
        private Guid _id;

        public License()
        {
            _id = Guid.NewGuid();
            Data = new ObservableCollection<UserData>();
        }

        [DataMember]
        public virtual Guid ID
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyOfPropertyChange(() => ID);
            }
        }

        [DataMember]
        public virtual string OwnerID
        {
            get { return _ownerId; }
            set
            {
                _ownerId = value;
                NotifyOfPropertyChange(() => OwnerID);
            }
        }

		[DataMember]
		public virtual string Plugin
		{
			get { return _plugin; }
			set
			{
				_plugin = value;
				NotifyOfPropertyChange(() => Plugin);
			}
		}

		public string PluginName
		{
			get
			{
				var info = PluginInfo;

				if (info != null && info.Length > 1)
					return info[1].Trim();

				return String.Empty;
			}
		}

		public string PluginID
		{
			get
			{
				var info = PluginInfo;

				if (info != null && info.Length > 0)
					return info[0].Trim();

				return String.Empty;
			}
		}

		protected string[] PluginInfo
		{
			get
			{
				return Plugin.Trim().Split(':');
			}
		}

		[DataMember]
        public virtual DateTime? ExpirationDate
        {
            get { return _expirationDate; }
            set
            {
                _expirationDate = value;
                NotifyOfPropertyChange(() => ExpirationDate);
            }
        }

        [DataMember]
        public virtual LicenseType LicenseType
        {
            get { return _licenseType; }
            set
            {
                _licenseType = value;
                NotifyOfPropertyChange(() => LicenseType);
            }
        }

        [DataMember]
        public virtual ObservableCollection<UserData> Data
        {
            get { return _data; }
            private set
            {
                _data = value;
                NotifyOfPropertyChange(() => Data);
            }
        }
    }
}