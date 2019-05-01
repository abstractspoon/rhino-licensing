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
        private string _ownerEmail;
		private string _pluginID;
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
        public virtual string OwnerEmail
        {
            get { return _ownerEmail; }
            set
            {
                _ownerEmail = value;
                NotifyOfPropertyChange(() => OwnerEmail);
            }
        }

		[DataMember]
		public virtual string PluginID
		{
			get { return _pluginID; }
			set
			{
				_pluginID = value;
				NotifyOfPropertyChange(() => PluginID);
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