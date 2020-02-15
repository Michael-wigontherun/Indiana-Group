/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.indiana.csv;
import com.indiana.SystemKey;
import com.indiana.TruckingCompanies;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.maps.GeoApiContext;
import com.google.maps.GeocodingApi;
import com.google.maps.errors.ApiException;
import com.google.maps.model.GeocodingResult;
import com.sun.xml.internal.ws.api.message.ExceptionHasMessage;

import java.io.*;
import java.sql.*;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.*;

/**
 *
 * @author Michael
 */
public class truckingCompaniesCSV extends TruckingCompanies {
    /**
     * Static method to pull the trucking company data from csv
     * Recommended if you do not have sufficient ram
     * @param csvLocation - location of csv file and name and extension of file
     * @param errorOutputLocation - location to output the errored files will open on windows - "_Error_List[date].sql"
     * @param executeAmount - amount of rows you want executed, -1 if you dont want it to stop until end of file
     */
    public static void TruckingMainWindowsConsoleQueryWReading(String csvLocation, String errorOutputLocation, int executeAmount){
        //for sql
        BufferedReader csvReader = null;
        truckingCompaniesCSV t = new truckingCompaniesCSV(SystemKey.Key, false);
        Connection con = null;
        //for PrintWriter
        String file = errorOutputLocation + String.format("_Error_List%s.sql", getDateStatic());
        PrintWriter fileWriter = null;
        try {
            fileWriter = new PrintWriter(file);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        //--------
        try {
            csvReader = new BufferedReader(new FileReader(csvLocation));
            String row = csvReader.readLine();
            int f = 0;
            con = DriverManager.getConnection(SystemKey.azureConnectionString);
            while ((row = csvReader.readLine()) != null) {
                t.csvRowDataSet(row, ",","update", f);
                String SQL = t.toSQLInsert();
                System.out.println(SQL);
                try {
                    Statement stml = con.createStatement();
                    stml.execute(SQL);
                } catch (SQLException ex) {
                    System.out.println(ex.getMessage());
                    if (fileWriter != null) {
                        fileWriter.write(SQL+"\n");
                        System.out.println("Outputting to output sql file.");
                    }
                }
                t.clearData();
                f++;
                if(f==executeAmount)break;
            }
        } catch (IOException | SQLException ex) {
            ex.printStackTrace();
        } finally {
            try {
                if (csvReader != null) {
                    csvReader.close();
                }
                if (con != null) {
                    con.close();
                }
                if (fileWriter != null) {
                    fileWriter.close();
                }
                Runtime.getRuntime().exec("explorer.exe /select, "+file);
            } catch (Exception ex) {
                ex.printStackTrace();
            }
        }
    }
    /**
     * Static method to pull the trucking company data from csv to a list than querying
     * @param csvLocation - location of csv file and name and extension of file
     * @param errorOutputLocation - location to output the errored files will open on windows - "_Error_List[date].sql"
     * @param executeAmount - amount of rows you want executed, -1 if you dont want it to stop until end of file
     */
    public static void TruckingMainWindowsConsoleListTQuery(String csvLocation, String errorOutputLocation, int executeAmount){
        //for sql
        BufferedReader csvReader = null;
        truckingCompaniesCSV t = new truckingCompaniesCSV(SystemKey.Key, false);
        List<String> SQLList = new ArrayList<String>();
        Connection con = null;
        Statement stml;
        String SQL = "";
        //for PrintWriter
        String file = errorOutputLocation + String.format("_Error_List%s.sql", getDateStatic());
        PrintWriter fileWriter = null;
        try {
            fileWriter = new PrintWriter(file);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        //--------
        try {
            csvReader = new BufferedReader(new FileReader(csvLocation));
            String row = csvReader.readLine();
            int f = 0;
            while ((row = csvReader.readLine()) != null) {
                if(f==executeAmount)break;
                t.csvRowDataSet(row, ",","update", f);
                SQL = t.toSQLInsert();
                System.out.println(SQL);
                SQLList.add(SQL);

                t.clearData();
                f++;
            }
            con = DriverManager.getConnection(SystemKey.azureConnectionString);
            try {
                for(String sql: SQLList) {
                    stml = con.createStatement();
                    stml.execute(sql);
                }
            } catch (SQLException ex) {
                System.out.println(ex.getMessage());
                fileWriter.write(SQL+"\n");
                System.out.println("Outputting to output sql file.");
            }
        } catch (IOException | SQLException e) {
            e.printStackTrace();
        } finally {
            try {
                if (csvReader != null) {
                    csvReader.close();
                }
                if (con != null) {
                    con.close();
                }
                if (fileWriter != null) {
                    fileWriter.close();
                }
                Runtime.getRuntime().exec("explorer.exe /select, "+file);
            } catch (Exception ex) {
                ex.printStackTrace();
            }
        }
    }

    /**
     * Static method to run though entire csv and output records that did not go through to new csv called "failedToPossess[date].csv"
     * @param csvLocation - location of csv file and name and extension of file
     * @param CSVOutputLocation - location to output the un inserted records
     */
    public static void TruckingUnloadedCompanies(String csvLocation, String CSVOutputLocation) throws Throwable {
        BufferedReader csvReader = null;
        List<String> csvRowList = new ArrayList<String>();
        Connection con = null;
        Statement stml = null;
        ResultSet rs = null;
        String SQL = "";
        Map<String,String> SQLMap = new HashMap<String,String>();
        //for PrintWriter
        String file = CSVOutputLocation + String.format("\\failedToPossess%s.sql", getDateStatic());
        PrintWriter fileWriter = null;
        //--------
        try {
            //read csv
            csvReader = new BufferedReader(new FileReader(csvLocation));
            System.out.println("csv opened.");
            String row = csvReader.readLine();
            while ((row = csvReader.readLine()) != null) {
                csvRowList.add(row);
            }
            System.out.println(csvRowList.size() + " records added to memory from csv.");
            csvReader.close();
            System.out.println("csv closed.");
            //end csv read

            //start csv writer
            fileWriter = new PrintWriter(file);
            System.out.println(String.format("\"%s\" created or opened at \"" + CSVOutputLocation + "\"",String.format("\\failedToPossess%s.sql", getDateStatic())));
            fileWriter.write("USDOT,_LEGAL_NAME_,_DBA_NAME_,_CARRIER_OPERATION_,_HM_FLAG_,_PC_FLAG_,_PHY_STREET_,_PHY_CITY_,_PHY_STATE_,_PHY_ZIP_,_PHY_COUNTRY_,_MAILING_STREET_,_MAILING_CITY_,_MAILING_STATE_,_MAILING_ZIP_,_MAILING_COUNTRY_,_TELEPHONE_,_FAX_,_EMAIL_ADDRESS_,_MCS150_DATE_,_MCS150_MILEAGE_,_MCS150_MILEAGE_YEAR_,_ADD_DATE_,_OIC_STATE_,_NBR_POWER_UNIT_,_DRIVER_TOTAL_\n");

            //start database pull
            try {
                con = DriverManager.getConnection(SystemKey.azureConnectionString);
                System.out.println("Database Connected!");
                SQL = "select usdot from TruckingCompanies";
                stml = con.createStatement();
                rs = stml.executeQuery(SQL);
                while (rs.next()){
                    SQLMap.put(rs.getString(1),"found");
                }
                System.out.println(SQLMap.size() + " records written to memory from database");
            } catch (SQLException ex) {
                System.out.println("System closing");
                throw ex;
            } finally {
                if (rs != null) {
                    rs.close();
                }
                if (stml != null) {
                    stml.close();
                }
                if (con != null) {
                    con.close();
                }
            }
            System.out.println(SQLMap.size());
            System.out.println(SQLMap.containsKey("w"));
            //end database pull
            System.out.println("Parsing through map.");
            String s = "";
            for(String usDot: csvRowList) {
                //String[] data = usDot.split("'");
                String[] data = usDot.split(",");
                s = SQLMap.get(data[0]);
                if(!SQLMap.containsKey(data[0])){
                    fileWriter.write(usDot+"\n");
                }
            }
            //write csv end
        } catch (Throwable ex) {
            if (fileWriter != null) {
                fileWriter.close();
                Runtime.getRuntime().exec("explorer.exe /select, "+file);
            }
            throw ex;
        } finally {
            if (fileWriter != null) {
                fileWriter.close();
                Runtime.getRuntime().exec("explorer.exe /select, "+file);
            }
        }
    }

    /**
     * Static method to generate a csv with the correct order of columns
     * this will open the file explorer with the "TruckingCompany[date].csv" file selected
     * @param outputPath - The path to where it is to be outputted
     * @param openFile - true if you want to open file in windows file explorer, false does not open in explorer
     * @return's filepath with file like: "C:\TruckingCompany.csv" or the error with ? at index[0] if fails
     */
    public static String createCSV(String outputPath, boolean openFile){
        String file = outputPath+String.format("\\TruckingCompany%s.csv", getDateStatic());
        try {
            PrintWriter writer = new PrintWriter(file);
            writer.write("USDOT,_LEGAL_NAME_,_DBA_NAME_,_CARRIER_OPERATION_,_HM_FLAG_,_PC_FLAG_,_PHY_STREET_,_PHY_CITY_,_PHY_STATE_,_PHY_ZIP_,_PHY_COUNTRY_,_MAILING_STREET_,_MAILING_CITY_,_MAILING_STATE_,_MAILING_ZIP_,_MAILING_COUNTRY_,_TELEPHONE_,_FAX_,_EMAIL_ADDRESS_,_MCS150_DATE_,_MCS150_MILEAGE_,_MCS150_MILEAGE_YEAR_,_ADD_DATE_,_OIC_STATE_,_NBR_POWER_UNIT_,_DRIVER_TOTAL_");
            writer.close();
            if(openFile) {
                Runtime.getRuntime().exec("explorer.exe /select, " + file);
            }
            return file;
        } catch (IOException e) {
            return "?" + e.getMessage();
        }
    }

    /**
     *  This method outputs "TruckingGeolocationFailures[date].csv" to a specified location containing all rows that google did not find the coordinates for
     * @param outputPath - the path to the folder to output to
     */
    public static void GetFailedGeoLocations(String outputPath){
        String file = outputPath+String.format("\\TruckingGeolocationFailures%s.csv", getDateStatic());
        PrintWriter writer = null;
        Connection con = null;
        Statement stml = null;
        ResultSet rs = null;
        String SQL;
        try {
            con = DriverManager.getConnection(SystemKey.azureConnectionString);
            System.out.println("Database Connected!");
            SQL = "select * from TruckingCompanies where GeoLocation = '-NA-'";
            stml = con.createStatement();
            rs = stml.executeQuery(SQL);
            writer = new PrintWriter(file);
            writer.write("USDOT,_LEGAL_NAME_,_DBA_NAME_,_CARRIER_OPERATION_,_HM_FLAG_,_PC_FLAG_,_PHY_STREET_,_PHY_CITY_,_PHY_STATE_,_PHY_ZIP_,_PHY_COUNTRY_,_MAILING_STREET_,_MAILING_CITY_,_MAILING_STATE_,_MAILING_ZIP_,_MAILING_COUNTRY_,_TELEPHONE_,_FAX_,_EMAIL_ADDRESS_,_MCS150_DATE_,_MCS150_MILEAGE_,_MCS150_MILEAGE_YEAR_,_ADD_DATE_,_OIC_STATE_,_NBR_POWER_UNIT_,_DRIVER_TOTAL_\n");
            while (rs.next()){
                writer.write(rs.getString(1)+","+rs.getString(2)+","+rs.getString(3)+","+rs.getString(4)+","+rs.getString(5)+","+rs.getString(6)+","+
                        rs.getString(7)+","+rs.getString(8)+","+rs.getString(9)+","+rs.getString(10)+","+rs.getString(11)+","+rs.getString(12)+","+
                        rs.getString(13)+","+rs.getString(14)+","+rs.getString(15)+","+rs.getString(16)+","+rs.getString(17)+","+rs.getString(18)+","+
                        rs.getString(19)+","+rs.getString(20)+","+rs.getString(21)+","+rs.getString(22)+","+rs.getString(23)+","+rs.getString(24)+","
                        +rs.getString(25)+","+rs.getString(26)+","+rs.getString(27)+","+rs.getString(28)+"\n");
            }
            Runtime.getRuntime().exec("explorer.exe /select, " + file);
        } catch (IOException | SQLException e) {
            e.printStackTrace();
        }finally {
            if (writer != null) {
                writer.close();
            }
            try {
                rs.close();
                stml.close();
                con.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }

    private String[] monthsText = new String[]{"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
    private List<String> monthTextList;

    private GeoApiContext context;

    private boolean fail = false;
    private boolean askGeo = false;

    private int columnIndex = 0;



    /**
     * Default constructor sets list and context
     * @param Key is your google API Key
     * @param askGeo is if you want to manually input coordinates on fail
     */
    public truckingCompaniesCSV(String Key, boolean askGeo) {
        this.askGeo = askGeo;
        monthTextList = Arrays.asList(monthsText);
        context = new GeoApiContext.Builder()
                .apiKey(Key)
                .build();
    }
    /**
     * Sets list, context, and all collums to there needed data spaces
     * @param Key - your google API Key
     * @param askGeo is if you want to manually input coordinates on fail
     * @param csvRow - Row data set of 26 rows
     * @param delimiter - The delimiter used in the csv
     * @param adminID - addmin's ID or if automated update input "update" or empty String to apply "update[MM/DD/YYYY]" to addmin ID
     * @param askGeo - true if you want to be asked if you want to manually input cowardinates on google fail
     * @param rowIndex - the row index of the record in the csv
     * Intended collum structure
     * USDOT,_LEGAL_NAME_,_DBA_NAME_,_CARRIER_OPERATION_,_HM_FLAG_,_PC_FLAG_,_PHY_STREET_,_PHY_CITY_,_PHY_STATE_,_PHY_ZIP_,_PHY_COUNTRY_,_MAILING_STREET_,_MAILING_CITY_,_MAILING_STATE_,_MAILING_ZIP_,_MAILING_COUNTRY_,_TELEPHONE_,_FAX_,_EMAIL_ADDRESS_,_MCS150_DATE_,_MCS150_MILEAGE_,_MCS150_MILEAGE_YEAR_,_ADD_DATE_,_OIC_STATE_,_NBR_POWER_UNIT_,_DRIVER_TOTAL_
     * dates are to be input'd as [DD/MM/YYYY]
     */
    public truckingCompaniesCSV(String Key, String csvRow, String delimiter, String adminID, int rowIndex, boolean askGeo) {
        this.askGeo = askGeo;
        monthTextList = Arrays.asList(monthsText);
        context = new GeoApiContext.Builder()
                .apiKey(Key)
                .build();
        csvRowDataSet(csvRow,delimiter, adminID, rowIndex);
    }
    /**
     * Sets all rows to there needed data spaces
     * @param csvRow - Row data set of 26 rows
     * @param delimiter - The delimiter used in the csv
     * @param adminID - addmin's ID or if automated update input "update" or empty String to apply "update[MM/DD/YYYY]" to addmin ID
     * @param rowIndex - the row index of the record in the csv
     * Intended collum structure
     * USDOT,_LEGAL_NAME_,_DBA_NAME_,_CARRIER_OPERATION_,_HM_FLAG_,_PC_FLAG_,_PHY_STREET_,_PHY_CITY_,_PHY_STATE_,_PHY_ZIP_,_PHY_COUNTRY_,_MAILING_STREET_,_MAILING_CITY_,_MAILING_STATE_,_MAILING_ZIP_,_MAILING_COUNTRY_,_TELEPHONE_,_FAX_,_EMAIL_ADDRESS_,_MCS150_DATE_,_MCS150_MILEAGE_,_MCS150_MILEAGE_YEAR_,_ADD_DATE_,_OIC_STATE_,_NBR_POWER_UNIT_,_DRIVER_TOTAL_
     * dates are to be input'd as [DD/MM/YYYY]
     */
    public void csvRowDataSet(String csvRow, String delimiter, String adminID, int rowIndex){
        this.columnIndex = rowIndex;
        monthTextList = Arrays.asList(monthsText);
        String[] data = csvRow.split(delimiter);
        try{
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
            setGeoLocation();
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
        }catch (Exception ex) {
            fail = true;
        }finally {
            setAdminId(adminID);
        }
    }

    /**
     *
     * @return's intended data structure for SQL insert
     * Intended collum structure
     * USDOT,_LEGAL_NAME_,_DBA_NAME_,_CARRIER_OPERATION_,_HM_FLAG_,_PC_FLAG_,_PHY_STREET_,_PHY_CITY_,_PHY_STATE_,_PHY_ZIP_,_PHY_COUNTRY_,_MAILING_STREET_,_MAILING_CITY_,_MAILING_STATE_,_MAILING_ZIP_,_MAILING_COUNTRY_,_TELEPHONE_,_FAX_,_EMAIL_ADDRESS_,_MCS150_DATE_,_MCS150_MILEAGE_,_MCS150_MILEAGE_YEAR_,_ADD_DATE_,_OIC_STATE_,_NBR_POWER_UNIT_,_DRIVER_TOTAL_
     * dates are to be input'd as [DD/MM/YYYY]
     */
    public String toSQLInsert() {
        String s = "'" + Usdot + "','" + LegalName + "','" + Dbaname + "','" + CarrierOperation + "',"
                    + "'" + HmFlag + "','" + PcFlag + "','" + PhyStreet + "','" + PhyCity + "','" + PhyState + "','" + PhyZip + "','" + PhyCountry + "',"
                    + "'" + MailingStreet + "','" + MailingCity + "','" + MailingState + "','" + MailingZip + "','" + MailingCountry + "','" + Telephone + "',"
                    + "'" + Fax + "','" + EmailAddress + "','" + Mcs150Date + "'," + Mcs150Mileage + ",'" + Mcs150MileageYear + "','" + AddDate + "',"
                    + "'" + OicState + "'," + NbrPowerUnit + "," + DriverTotal + ",'" + GeoLocation + "','" + AdminId + "'";
        String SQL = String.format("INSERT INTO TruckingCompanies VALUES (%s);", s);
        if (fail) return "?--" + SQL + "\n--Above failed due to invalid data structure due at collum index: " + columnIndex;
        return SQL;
    }

    /**
     * For optimization of single row enter not for list's
     * Run this method when starting a new insert
     * Do not use if you are creating a list of this object
     */
    public void clearData() {
        Usdot = "";
        LegalName = "";
        Dbaname = "";
        CarrierOperation = "";
        HmFlag = "";
        PcFlag = "";
        PhyStreet = "";
        PhyCity = "";
        PhyState = "";
        PhyZip = "";
        PhyCountry = "";
        MailingStreet = "";
        MailingCity = "";
        MailingState = "";
        MailingZip = "";
        MailingCountry = "";
        Telephone = "";
        Fax = "";
        EmailAddress = "";
        Mcs150Date = "";
        Mcs150Mileage = "NULL";
        Mcs150MileageYear = "";
        AddDate = "";
        OicState = "";
        NbrPowerUnit = "NULL";
        DriverTotal = "NULL";
        GeoLocation = "";
        setAdminId("update");
        fail = false;
    }
    

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
    /**
     * Method to format PhyZip to a length of 5
     * @param MailingZip - is _MAILING_ZIP_
     */
    public void setMailingZip(String MailingZip){
        if(MailingZip.length() > 5){
            MailingZip = MailingZip.trim().substring(0, 5);
        }
        this.MailingZip = MailingZip;
    }
    /**
     * Sets date to [MM-DD-YYYY]
     * @param Mcs150Date - _MCS150_DATE_ must be in [DD-MMM-YYYY]
     */
    public void setMcs150Date(String Mcs150Date){
        this.Mcs150Date = dateBulder(Mcs150Date);
    }
    /**
     * Sets date to [MM-DD-YYYY]
     * @param AddDate - _ADD_DATE_ must be in [DD-MMM-YYYY]
     */
    public void setAddDate(String AddDate){
        this.AddDate = dateBulder(AddDate);
    }

    public void setLegalName(String LegalName) {
        this.LegalName = LegalName.replaceAll("'","''");
    }


    public void setDbaname(String Dbaname) {
        if(stringIsEmpty(Dbaname)){
            Dbaname = "";
        }
        this.Dbaname = Dbaname.replaceAll("'","''");
    }

    public void setTelephone(String Telephone) {
        if(stringIsEmpty(Telephone)){
            Telephone = "";
        }
        this.Telephone = Telephone;
    }

    public void setFax(String Fax) {
        if(stringIsEmpty(Fax)){
            Fax = "";
        }
        this.Fax = Fax;
    }

    public void setEmailAddress(String EmailAddress) {
        if(stringIsEmpty(EmailAddress)){
            EmailAddress = "";
        }
        this.EmailAddress = EmailAddress;
    }

    public void setMcs150Mileage(String Mcs150Mileage) {
        if(stringIsEmpty(Mcs150Mileage)){
            Mcs150Mileage = "NULL";
        }
        this.Mcs150Mileage = Mcs150Mileage;
    }

    public void setMcs150MileageYear(String Mcs150MileageYear) {
        if(stringIsEmpty(Mcs150MileageYear)){
            Mcs150MileageYear = "";
        }
        this.Mcs150MileageYear = Mcs150MileageYear;
    }

    public void setNbrPowerUnit(String NbrPowerUnit) {
        if(stringIsEmpty(NbrPowerUnit)){
            NbrPowerUnit = "NULL";
        }
        this.NbrPowerUnit = NbrPowerUnit;
    }

    public void setDriverTotal(String DriverTotal) {
        if(stringIsEmpty(DriverTotal)){
            DriverTotal = "NULL";
        }
        this.DriverTotal = DriverTotal;
    }

    /**
     * only call if full Phy address data is added
     */
    public void setGeoLocation() {
        try {
            GeocodingResult[] results =  GeocodingApi.geocode(context,getFullPhyAddress()).await();
            Gson gson = new GsonBuilder().setPrettyPrinting().create();
            this.GeoLocation = gson.toJson(results[0].geometry.location.lat) + ":" + gson.toJson(results[0].geometry.location.lng);
        } catch (ApiException | IOException | InterruptedException | ArrayIndexOutOfBoundsException ex) {
            System.out.println(ex.getMessage());
            if(askGeo) {
                System.out.println("\n\n\n\n\n");
                System.out.println(ex.getMessage());
                this.GeoLocation = "-NA-";
                System.out.println("Could not find address defaulted to \"-NA-\"");
                System.out.println(getFullPhyAddress());
                Scanner k = new Scanner(System.in);
                String s;
                System.out.println("Enter longitude and latitude manually in [lat:lng] format or 999 to skip");
                if ((s = k.nextLine()).equals("999")) {
                    this.GeoLocation = "-NA-";
                } else {
                    this.GeoLocation = s;
                }
            }
            else this.GeoLocation = "-NA-";
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

    /**
     *
     * @return the full physical address string
     */
    public String getFullPhyAddress(){
        return PhyStreet + " " + PhyCity + ", " + PhyState + " " + PhyZip + ", " + PhyCountry;
    }
    /**
     * Makes admin id if there is no admin and its a normal update or "" to make it apply default update to database
     * @param AdminId - Admin id
     */
    public void setAdminId(String AdminId) {
        if(AdminId.equalsIgnoreCase("update") || AdminId.equals("")){
            AdminId = "update"+getDate();
        }
        this.AdminId = AdminId;
    }
    private boolean stringIsEmpty(String string){
        if(string.equals("")){
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
    private static String getDateStatic(){
        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("MM/dd/yyyy");
        LocalDate localDate = LocalDate.now();
        return  dtf.format(localDate).replaceAll("/","-");
    }
    private String getDate(){
        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("MM/dd/yyyy");
        LocalDate localDate = LocalDate.now();
        return  dtf.format(localDate).replaceAll("/","-");
    }
}
