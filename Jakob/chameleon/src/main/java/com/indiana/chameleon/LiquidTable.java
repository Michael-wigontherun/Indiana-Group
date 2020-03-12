package com.indiana.chameleon;
//CLASS IS SO THAT DATA FROM THE LIQUIDATEDCOMPANIES TABLE CAN BE USED
public class LiquidTable{
    String USDOT;
    String LegalName;
    String DBAName;
    String Address;
    String OOSReason;
    String OOSDate;
    String Status;
    String GeoLocation;
    String adminID;

    public String getUSDOT() {
        return USDOT;
    }

    public void setUSDOT(String uSDOT) {
        USDOT = uSDOT;
    }

    public String getLegalName() {
        return LegalName;
    }

    public void setLegalName(String legalName) {
        LegalName = legalName;
    }

    public String getDBAName() {
        return DBAName;
    }

    public void setDBAName(String dBAName) {
        DBAName = dBAName;
    }

    public String getAddress() {
        return Address;
    }

    public void setAddress(String address) {
        Address = address;
    }

    public String getOOSReason() {
        return OOSReason;
    }

    public void setOOSReason(String oOSReason) {
        OOSReason = oOSReason;
    }

    public String getOOSDate() {
        return OOSDate;
    }

    public void setOOSDate(String oOSDate) {
        OOSDate = oOSDate;
    }

    public String getStatus() {
        return Status;
    }

    public void setStatus(String status) {
        Status = status;
    }

    public String getGeoLocation() {
        return GeoLocation;
    }

    public void setGeoLocation(String geolocation) {
        GeoLocation = geolocation;
    }

    public String getAdminID() {
        return adminID;
    }

    public void setAdminID(String adminID) {
        this.adminID = adminID;
    }

    public LiquidTable() {
        USDOT = "";
        LegalName = "";
        DBAName = "";
        Address = "";
        OOSReason = "";
        OOSDate = "";
        Status = "";
        GeoLocation = "";
        adminID = "";
    }
    
}