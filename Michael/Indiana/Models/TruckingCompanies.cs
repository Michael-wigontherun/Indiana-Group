using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Indiana.Models
{
    public partial class TruckingCompanies
    {
        [Key]
        public string Usdot { get; set; }
        public string LegalName { get; set; }

        private string Dbaname_;
        public string Dbaname
        {
            get { return Dbaname_; }
            set
            {
                if (value == null)
                {
                    Dbaname_ = "";
                }
                else Dbaname_ = value;
            }
        }
        public string CARRIER_OPERATION_ { get; set; }
        public string HM_FLAG_ { get; set; }
        public string PC_FLAG_ { get; set; }
        public string PHY_STREET_ { get; set; }
        public string PHY_CITY_ { get; set; }
        public string PHY_STATE_ { get; set; }
        public string PHY_ZIP_ { get; set; }
        public string PHY_COUNTRY_ { get; set; }
        public string MAILING_STREET_ { get; set; }
        public string MAILING_CITY_ { get; set; }
        public string MAILING_STATE_ { get; set; }
        public string MAILING_ZIP_ { get; set; }
        public string MAILING_COUNTRY_ { get; set; }

        private string TELEPHONE;
        public string TELEPHONE_
        {
            get { return TELEPHONE; }
            set
            {
                if (value == null)
                {
                    TELEPHONE = "";
                }
                else TELEPHONE = value;
            }
        }

        private string FAX;
        public string FAX_
        {
            get { return FAX; }
            set
            {
                if (value == null)
                {
                    FAX = "";
                }
                else FAX = value;
            }
        }

        private string EMAIL_ADDRESS;
        public string EMAIL_ADDRESS_
        {
            get { return EMAIL_ADDRESS; }
            set
            {
                if (value == null)
                {
                    EMAIL_ADDRESS = "";
                }
                else EMAIL_ADDRESS = value;
            }
        }

        private string MCS150_DATE;
        public string MCS150_DATE_
        {
            get { return MCS150_DATE; }
            set
            {
                if (value == null)
                {
                    MCS150_DATE = "";
                }
                else MCS150_DATE = value;
            }
        }

        private int MCS150_MILEAGE;
        public int MCS150_MILEAGE_
        {
            get { return MCS150_MILEAGE; }
            set
            {
                if (value.Equals(null))
                {
                    MCS150_MILEAGE = -1;
                }
                else MCS150_MILEAGE = value;
            }
        }

        private string MCS150_MILEAGE_YEAR;
        public string MCS150_MILEAGE_YEAR_
        {
            get { return MCS150_MILEAGE_YEAR; }
            set
            {
                if (value == null)
                {
                    MCS150_MILEAGE_YEAR = "";
                }
                else MCS150_MILEAGE_YEAR = value;
            }
        }

        private string ADD_DATE;
        public string ADD_DATE_
        {
            get { return ADD_DATE; }
            set
            {
                if (value == null)
                {
                    ADD_DATE = "";
                }
                else ADD_DATE = value;
            }
        }
        public string OIC_STATE_ { get; set; }

        private int NBR_POWER_UNIT;
        public int NBR_POWER_UNIT_
        {
            get { return NBR_POWER_UNIT; }
            set
            {
                if (value == null)
                {
                    NBR_POWER_UNIT = -1;
                }
                else NBR_POWER_UNIT = value;
            }
        }
        public int DRIVER_TOTAL_ { get; set; }
        public string GeoLocation { get; set; }
        public string addminID { get; set; }
    }
}
