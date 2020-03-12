package com.indiana.chameleon;
//DATA CAN HOLD THE USDOT IF THE CHAMELEON COMPANY INORDER TO BE INSERTED INTO TABLE
public class Chameleon{
    String USDOT;
    String adminID;

    public String getUSDOT() {
        return USDOT;
    }

    public void setUSDOT(String uSDOT) {
        USDOT = uSDOT;
    }

    public String getAdminID() {
        return adminID;
    }

    public void setAdminID(String adminID) {
        this.adminID = adminID;
    }

    public Chameleon() {
        USDOT = "";
        adminID = "";
    }
    
}