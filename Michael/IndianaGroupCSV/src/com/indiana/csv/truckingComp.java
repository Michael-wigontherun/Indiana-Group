/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.indiana.csv;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.maps.GeoApiContext;
import com.google.maps.GeocodingApi;
import com.google.maps.errors.ApiException;
import com.google.maps.model.GeocodingResult;

import java.io.IOException;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Arrays;
import java.util.List;

/**
 *
 * @author Michael
 */
public class truckingComp {
    private String[] monthsText = new String[]{"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
    private List<String> monthTextList;
    private GeoApiContext context;

    /**
     * Default constructor sets list and context
     * @param Key is your google API Key
     */
    public truckingComp(String Key) {
        monthTextList = Arrays.asList(monthsText);
        context = new GeoApiContext.Builder()
                .apiKey(Key)
                .build();
    }
    /**
     * Sets list, context, and all collums to there needed data spaces
     * @param Key is your google API Key
     * @param csvRow - Row data set of 26 rows
     * @param delimiter - The delimiter used in the csv
     * @param adminID is addmin's ID or if automated update input "update" or empty String to apply "update[MM/DD/YYYY]" to addmin ID
     * Intended collum structure
     * USDOT,_LEGAL_NAME_,_DBA_NAME_,_CARRIER_OPERATION_,_HM_FLAG_,_PC_FLAG_,_PHY_STREET_,_PHY_CITY_,_PHY_STATE_,_PHY_ZIP_,_PHY_COUNTRY_,_MAILING_STREET_,_MAILING_CITY_,_MAILING_STATE_,_MAILING_ZIP_,_MAILING_COUNTRY_,_TELEPHONE_,_FAX_,_EMAIL_ADDRESS_,_MCS150_DATE_,_MCS150_MILEAGE_,_MCS150_MILEAGE_YEAR_,_ADD_DATE_,_OIC_STATE_,_NBR_POWER_UNIT_,_DRIVER_TOTAL_
     * dates are to be input'd as [DD/MM/YYYY]
     */
    public truckingComp(String Key, String csvRow, String delimiter, String adminID) {
        monthTextList = Arrays.asList(monthsText);
        context = new GeoApiContext.Builder()
                .apiKey(Key)
                .build();
        csvRowDataSet(csvRow,delimiter, adminID);
    }
    /**
     * Sets all rows to there needed data spaces
     * @param csvRow - Row data set of 26 rows
     * @param delimiter - The delimiter used in the csv
     * @param adminID is addmin's ID or if automated update input "update" or empty String to apply "update[MM/DD/YYYY]" to addmin ID
     * Intended collum structure
     * USDOT,_LEGAL_NAME_,_DBA_NAME_,_CARRIER_OPERATION_,_HM_FLAG_,_PC_FLAG_,_PHY_STREET_,_PHY_CITY_,_PHY_STATE_,_PHY_ZIP_,_PHY_COUNTRY_,_MAILING_STREET_,_MAILING_CITY_,_MAILING_STATE_,_MAILING_ZIP_,_MAILING_COUNTRY_,_TELEPHONE_,_FAX_,_EMAIL_ADDRESS_,_MCS150_DATE_,_MCS150_MILEAGE_,_MCS150_MILEAGE_YEAR_,_ADD_DATE_,_OIC_STATE_,_NBR_POWER_UNIT_,_DRIVER_TOTAL_
     * dates are to be input'd as [DD/MM/YYYY]
     */
    public void csvRowDataSet(String csvRow, String delimiter, String adminID) {
        monthTextList = Arrays.asList(monthsText);
        String[] data = csvRow.split(delimiter);
        setUsdot(data[0]);
        setLegalName(data[1]);
        setDbaname(data[2]);
        setCarrierOperation(data[3]);
        setHmFlag(data[4]);
        setPcFlag(data[5]);
        setPhyStreet(data[6]);
        setPhyCity(data[7]);
        setPhyState(data[8]);
        setPhyZip(data[9]);
        setPhyCountry(data[10]);
        setMailingStreet(data[11]);
        setMailingCity(data[12]);
        setMailingState(data[13]);
        setMailingZip(data[14]);
        setMailingCountry(data[15]);
        setTelephone(data[16]);
        setFax(data[17]);
        setEmailAddress(data[18]);
        setMcs150Date(data[19]);
        setMcs150Mileage(data[20]);
        setMcs150MileageYear(data[21]);
        setAddDate(data[22]);
        setOicState(data[23]);
        setNbrPowerUnit(data[24]);
        setDriverTotal(data[25]);
        setGeoLocation();
        setAddminId(adminID);
    }


    /**
     *
     * @return's intended data structure for SQL insert
     * Intended collum structure
     * USDOT,_LEGAL_NAME_,_DBA_NAME_,_CARRIER_OPERATION_,_HM_FLAG_,_PC_FLAG_,_PHY_STREET_,_PHY_CITY_,_PHY_STATE_,_PHY_ZIP_,_PHY_COUNTRY_,_MAILING_STREET_,_MAILING_CITY_,_MAILING_STATE_,_MAILING_ZIP_,_MAILING_COUNTRY_,_TELEPHONE_,_FAX_,_EMAIL_ADDRESS_,_MCS150_DATE_,_MCS150_MILEAGE_,_MCS150_MILEAGE_YEAR_,_ADD_DATE_,_OIC_STATE_,_NBR_POWER_UNIT_,_DRIVER_TOTAL_
     * dates are to be input'd as [DD/MM/YYYY]
     */
    public String toSQLInsertValues() {
        return "'" + Usdot + "','" + LegalName + "','" + Dbaname + "','" + CarrierOperation + "',"
             + "'" + HmFlag + "','" + PcFlag + "','" + PhyStreet + "','" + PhyCity + "','" + PhyState + "','" + PhyZip + "','" + PhyCountry + "',"
             + "'" + MailingStreet + "','" + MailingCity + "','" + MailingState + "','" + MailingZip + "','" + MailingCountry + "','" + Telephone + "',"
             + "'" + Fax + "','" + EmailAddress + "','" + Mcs150Date + "'," + Mcs150Mileage + ",'" + Mcs150MileageYear + "','" + AddDate + "',"
             + "'" + OicState + "'," + NbrPowerUnit + "," + DriverTotal + ",'" + GeoLocation + "','" + AddminId + "'";
    }

    /**
     * For optimization of single row enter not for list's
     * Run this method when starting a new insert
     * Do not use if you are creating a list of this object
     */
    public void clearData() {
        Usdot = null;
        LegalName = null;
        Dbaname = null;
        CarrierOperation = null;
        HmFlag = null;
        PcFlag = null;
        PhyStreet = null;
        PhyCity = null;
        PhyState = null;
        PhyZip = null;
        PhyCountry = null;
        MailingStreet = null;
        MailingCity = null;
        MailingState = null;
        MailingZip = null;
        MailingCountry = null;
        Telephone = null;
        Fax = null;
        EmailAddress = null;
        Mcs150Date = null;
        Mcs150Mileage = null;
        Mcs150MileageYear = null;
        AddDate = null;
        OicState = null;
        NbrPowerUnit = null;
        DriverTotal = null;
        GeoLocation = null;
        AddminId = null;
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

    /**
     * Method to format PhyZip to a length of 5
     * @param PhyZip - is _PHY_ZIP_
     */
    public void setPhyZip(String PhyZip){
        if(PhyZip.length() > 5){
            PhyZip = PhyZip.trim().substring(0, 5);
        }
        this.PhyZip = PhyZip;
    }
    public String getPhyZip(){
        return PhyZip;
    }
    private String PhyCountry;
    private String MailingStreet;
    private String MailingCity;
    private String MailingState;
    private String MailingZip;
    public void setMailingZip(String MailingZip){
        if(MailingZip.length() > 5){
            MailingZip = MailingZip.trim().substring(0, 5);
        }
        this.MailingZip = MailingZip;
    }
    public String getMailingZip(){
        return MailingZip;
    }
    private String MailingCountry;
    private String Telephone;
    private String Fax;
    private String EmailAddress;
    private String Mcs150Date;

    public void setMcs150Date(String Mcs150Date){

        this.Mcs150Date = dateBulder(Mcs150Date);

    }
    public String getMcs150Date(){
        return Mcs150Date;
    }

    private String Mcs150Mileage;
    private String Mcs150MileageYear;
    private String AddDate;
    public void setAddDate(String AddDate){
        this.AddDate = dateBulder(AddDate);
    }
    public String getAddDate(){
        return AddDate;
    }
    private String OicState;
    private String NbrPowerUnit;
    private String DriverTotal;
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
        if(stringIsEmpty(Dbaname)){
            Dbaname = "";
        }
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
        if(stringIsEmpty(Telephone)){
            Telephone = "";
        }
        this.Telephone = Telephone;
    }

    public String getFax() {
        return Fax;
    }

    public void setFax(String Fax) {
        if(stringIsEmpty(Fax)){
            Fax = "";
        }
        this.Fax = Fax;
    }

    public String getEmailAddress() {
        return EmailAddress;
    }

    public void setEmailAddress(String EmailAddress) {
        if(stringIsEmpty(EmailAddress)){
            EmailAddress = "";
        }
        this.EmailAddress = EmailAddress;
    }

    public String getMcs150Mileage() {
        return Mcs150Mileage;
    }

    public void setMcs150Mileage(String Mcs150Mileage) {
        if(stringIsEmpty(Mcs150Mileage)){
            Mcs150Mileage = "NULL";
        }
        this.Mcs150Mileage = Mcs150Mileage;
    }

    public String getMcs150MileageYear() {
        return Mcs150MileageYear;
    }

    public void setMcs150MileageYear(String Mcs150MileageYear) {
        if(stringIsEmpty(Mcs150MileageYear)){
            Mcs150MileageYear = "";
        }
        this.Mcs150MileageYear = Mcs150MileageYear;
    }

    public String getOicState() {
        return OicState;
    }

    public void setOicState(String OicState) {
        this.OicState = OicState;
    }

    public String getNbrPowerUnit() {
        return NbrPowerUnit;
    }

    public void setNbrPowerUnit(String NbrPowerUnit) {
        if(stringIsEmpty(NbrPowerUnit)){
            NbrPowerUnit = "NULL";
        }
        this.NbrPowerUnit = NbrPowerUnit;
    }

    public String getDriverTotal() {
        return DriverTotal;
    }

    public void setDriverTotal(String DriverTotal) {
        if(stringIsEmpty(DriverTotal)){
            DriverTotal = "NULL";
        }
        this.DriverTotal = DriverTotal;
    }

    public String getGeoLocation() {
        return GeoLocation;
    }

    /**
     * only call if full Phy address data is added
     */
    public void setGeoLocation() {
        try {
            GeocodingResult[] results =  GeocodingApi.geocode(context,getFullPhyAddress()).await();
            Gson gson = new GsonBuilder().setPrettyPrinting().create();
            this.GeoLocation = gson.toJson(results[0].geometry.location.lat) + ":" + gson.toJson(results[0].geometry.location.lng);
        } catch (ApiException | IOException | InterruptedException ex) {
            System.out.println(ex.getMessage());
            this.GeoLocation = "-NA-";
        }
    }
    /**
     * use only when you have not added Phy address data
     * after uses you do not need to call or add Phy address data
     */
    public void setGeoLocation(String PhyStreet,String PhyCity,String PhyState, String PhyZip, String PhyCountry) {
        setPhyStreet(PhyStreet);
        setPhyCity(PhyCity);
        setPhyState(PhyState);
        setPhyZip(PhyZip);
        setPhyCountry(PhyCountry);
        try {
            GeocodingResult[] results =  GeocodingApi.geocode(context,getFullPhyAddress()).await();
            Gson gson = new GsonBuilder().setPrettyPrinting().create();
            this.GeoLocation = gson.toJson(results[0].geometry.location.lat) + ":" + gson.toJson(results[0].geometry.location.lng);
        } catch (ApiException | IOException | InterruptedException ex) {
            System.out.println(ex.getMessage());
            this.GeoLocation = "-NA-";
        }
    }
    public String getFullPhyAddress(){
        return PhyStreet + " " + PhyCity + ", " + PhyState + " " + PhyZip + ", " + PhyCountry;
    }
    public String getAddminId() {
        return AddminId;
    }

    /**
     * Makes addmin id if there is no admin and its a normal update or "" to make it apply default update to database
     * @param AddminId
     */
    public void setAddminId(String AddminId) {
        if(AddminId.equalsIgnoreCase("update") || AddminId.equals("")){
            DateTimeFormatter dtf = DateTimeFormatter.ofPattern("MM/dd/yyyy");
            LocalDate localDate = LocalDate.now();
            AddminId = "update"+dtf.format(localDate);
        }
        this.AddminId = AddminId;
    }
    private boolean stringIsEmpty(String string){
        if(string.equals("")){
            return true;
        }
        else if(string == null){
            return true;
        }
        return false;
    }
    private String dateBulder(String date){
        if(stringIsEmpty(date)){
            return "-NA-";
        }
        String month;
        String day;
        String year;
        try{
            String[] dateArr = date.split("-");
            month = (monthTextList.indexOf(dateArr[1]) + 1) + "";
            if(month.length() <2) month = "0" + month;

            day = dateArr[0];
            if(day.length() <2) day = "0" + day;

            year = dateArr[2];
            if(year.length() <4){
                if(Integer.parseInt(year) > 20){
                    year = "19" + year;
                }
                else{
                    year = "20"+year;
                }
            }
        }catch(Exception e){
            return "-NA-";
        }
        return month+"/"+day+"/"+year;
    }
}
