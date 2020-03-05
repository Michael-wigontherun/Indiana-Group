package com.indiana.chameleon;

public class TruckingTable{
    String USDOT;
    String LegalName;
    String DBAName;
    String MCS150_Date;
    String GeoLocation;
    String PHY_STREET_;
    String PHY_CITY_;
    String PHY_STATE_;
    String PHY_ZIP_;
    
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

    public String getMCS150_Date() {
        return MCS150_Date;
    }

    public void setMCS150_Date(String mCS150_Date) {
        MCS150_Date = mCS150_Date;
    }

    public String getGeoLocation() {
        return GeoLocation;
    }

    public void setGeoLocation(String geoLocation) {
        GeoLocation = geoLocation;
    }

    public String getPHY_STREET_() {
        return PHY_STREET_;
    }

    public void setPHY_STREET_(String pHY_STREET_) {
        PHY_STREET_ = pHY_STREET_;
    }

    public String getPHY_CITY_() {
        return PHY_CITY_;
    }

    public void setPHY_CITY_(String pHY_CITY_) {
        PHY_CITY_ = pHY_CITY_;
    }

    public String getPHY_STATE_() {
        return PHY_STATE_;
    }

    public void setPHY_STATE_(String pHY_STATE_) {
        PHY_STATE_ = pHY_STATE_;
    }

    public String getPHY_ZIP_() {
        return PHY_ZIP_;
    }

    public void setPHY_ZIP_(String pHY_ZIP_) {
        PHY_ZIP_ = pHY_ZIP_;
    }

    public TruckingTable() {
        USDOT = "";
        LegalName = "";
        DBAName = "";
        MCS150_Date = "";
        GeoLocation = "";
        PHY_STREET_ = "";
        PHY_CITY_ = "";
        PHY_STATE_ = "";
        PHY_ZIP_ = "";
    }
    
}