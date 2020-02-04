/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package indianacsvconverter;

import java.util.Arrays;
import java.util.List;

/**
 *
 * @author Owner
 */
public class truckingComp {
    private String[] monthsText = new String[]{"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
    private List<String> monthTextList;
    public truckingComp() {
        monthTextList = Arrays.asList(monthsText);
    }

    
    public String toSQLInsertValues() {
        return "'" + monthsText + "','" + monthTextList + "','" + Usdot + "','" + LegalName + "','" + Dbaname + "','" + CarrierOperation + "',"
             + "'" + HmFlag + "','" + PcFlag + "','" + PhyStreet + "','" + PhyCity + "','" + PhyState + "','" + PhyZip + "','" + PhyCountry + "',"
             + "'" + MailingStreet + "','" + MailingCity + "','" + MailingState + "','" + MailingZip + "','" + MailingCountry + "','" + Telephone + "',"
             + "'" + Fax + "','" + EmailAddress + "','" + Mcs150Date + "'," + Mcs150Mileage + ",'" + Mcs150MileageYear + "','" + AddDate + "',"
             + "'" + OicState + "'," + NbrPowerUnit + "," + DriverTotal + ",'" + GeoLocation + "','" + AddminId;
    }
    
    private String Usdot;
    private String LegalName;
    private String Dbaname;
    private String CarrierOperation;
    private String HmFlag;
    private String PcFlag;
    private String PhyStreet;
    private String PhyCity;
    private String PhyState;
    private String PhyZip;
    public void setPhyZip(String zip){
        if(zip.length() > 5){
            zip = zip.substring(0, 5);
        }
        PhyZip = zip;
    }
    public String getPhyZip(){
        return PhyZip;
    }
    private String PhyCountry;
    private String MailingStreet;
    private String MailingCity;
    private String MailingState;
    private String MailingZip;
    public void setMailingZip(String zip){
        if(zip.length() > 5){
            zip = zip.substring(0, 5);
        }
        MailingZip = zip;
    }
    public String getMailingZip(){
        return MailingZip;
    }
    private String MailingCountry;
    private String Telephone;
    private String Fax;
    private String EmailAddress;
    private String Mcs150Date;
    public void setMcs150Date(String date){
        if(date.equals("") || date == null){
            Mcs150Date = "-NA-";
            return;
        }
        try{
        String[] dateArr = date.split("-");
        String month = (monthTextList.indexOf(dateArr[1]) + 1) + "";
        String day = dateArr[0];
        String year = dateArr[2];
        if(year.length() <4){
            if(Integer.parseInt(year) > 20){
                year = "19" + year;
            }
            else{
                year = "20"+year;
            }
        }
        Mcs150Date = month+"/"+day+"/"+year;
        }catch(Exception e){
            Mcs150Date = "-NA-";
        }
    }
    public String getMcs150Date(){
        return Mcs150Date;
    }
    private int Mcs150Mileage;
    private String Mcs150MileageYear;
    private String AddDate;
    public void setAddDate(String date){
        if(date.equals("") || date == null){
            AddDate = "-NA-";
            return;
        }
        try{
        String[] dateArr = date.split("-");
        String month = (monthTextList.indexOf(dateArr[1]) + 1) + "";
        String day = dateArr[0];
        String year = dateArr[2];
        if(year.length() <4){
            if(Integer.parseInt(year) > 20){
                year = "19" + year;
            }
            else{
                year = "20"+year;
            }
        }
        AddDate = month+"/"+day+"/"+year;
        }catch(Exception e){
            AddDate = "-NA-";
        }
    }
    public String getAddDate(){
        return AddDate;
    }
    private String OicState;
    private int NbrPowerUnit;
    private int DriverTotal;
    private String GeoLocation;
    private String AddminId;

    public String getUsdot() {
        return Usdot;
    }

    public void setUsdot(String Usdot) {
        this.Usdot = Usdot;
    }

    public String getLegalName() {
        return LegalName;
    }

    public void setLegalName(String LegalName) {
        this.LegalName = LegalName;
    }

    public String getDbaname() {
        return Dbaname;
    }

    public void setDbaname(String Dbaname) {
        this.Dbaname = Dbaname;
    }

    public String getCarrierOperation() {
        return CarrierOperation;
    }

    public void setCarrierOperation(String CarrierOperation) {
        this.CarrierOperation = CarrierOperation;
    }

    public String getHmFlag() {
        return HmFlag;
    }

    public void setHmFlag(String HmFlag) {
        this.HmFlag = HmFlag;
    }

    public String getPcFlag() {
        return PcFlag;
    }

    public void setPcFlag(String PcFlag) {
        this.PcFlag = PcFlag;
    }

    public String getPhyStreet() {
        return PhyStreet;
    }

    public void setPhyStreet(String PhyStreet) {
        this.PhyStreet = PhyStreet;
    }

    public String getPhyCity() {
        return PhyCity;
    }

    public void setPhyCity(String PhyCity) {
        this.PhyCity = PhyCity;
    }

    public String getPhyState() {
        return PhyState;
    }

    public void setPhyState(String PhyState) {
        this.PhyState = PhyState;
    }

    public String getPhyCountry() {
        return PhyCountry;
    }

    public void setPhyCountry(String PhyCountry) {
        this.PhyCountry = PhyCountry;
    }

    public String getMailingStreet() {
        return MailingStreet;
    }

    public void setMailingStreet(String MailingStreet) {
        this.MailingStreet = MailingStreet;
    }

    public String getMailingCity() {
        return MailingCity;
    }

    public void setMailingCity(String MailingCity) {
        this.MailingCity = MailingCity;
    }

    public String getMailingState() {
        return MailingState;
    }

    public void setMailingState(String MailingState) {
        this.MailingState = MailingState;
    }

    public String getMailingCountry() {
        return MailingCountry;
    }

    public void setMailingCountry(String MailingCountry) {
        this.MailingCountry = MailingCountry;
    }

    public String getTelephone() {
        return Telephone;
    }

    public void setTelephone(String Telephone) {
        this.Telephone = Telephone;
    }

    public String getFax() {
        return Fax;
    }

    public void setFax(String Fax) {
        this.Fax = Fax;
    }

    public String getEmailAddress() {
        return EmailAddress;
    }

    public void setEmailAddress(String EmailAddress) {
        this.EmailAddress = EmailAddress;
    }

    public int getMcs150Mileage() {
        return Mcs150Mileage;
    }

    public void setMcs150Mileage(int Mcs150Mileage) {
        this.Mcs150Mileage = Mcs150Mileage;
    }

    public String getMcs150MileageYear() {
        return Mcs150MileageYear;
    }

    public void setMcs150MileageYear(String Mcs150MileageYear) {
        this.Mcs150MileageYear = Mcs150MileageYear;
    }

    public String getOicState() {
        return OicState;
    }

    public void setOicState(String OicState) {
        this.OicState = OicState;
    }

    public int getNbrPowerUnit() {
        return NbrPowerUnit;
    }

    public void setNbrPowerUnit(int NbrPowerUnit) {
        this.NbrPowerUnit = NbrPowerUnit;
    }

    public int getDriverTotal() {
        return DriverTotal;
    }

    public void setDriverTotal(int DriverTotal) {
        this.DriverTotal = DriverTotal;
    }

    public String getGeoLocation() {
        return GeoLocation;
    }

    public void setGeoLocation(String GeoLocation) {
        this.GeoLocation = GeoLocation;
    }

    public String getAddminId() {
        return AddminId;
    }

    public void setAddminId(String AddminId) {
        this.AddminId = AddminId;
    }
    
    
}
