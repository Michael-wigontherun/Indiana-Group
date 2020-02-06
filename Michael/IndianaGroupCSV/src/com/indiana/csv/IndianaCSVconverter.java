/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.indiana.csv;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

/**
 *
 * @author Owner
 */
public class IndianaCSVconverter {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        BufferedReader csvReader = null;
        try {
            String pathToCsv = "F:\\IndianaGroup\\Indiana-Group\\Michael\\indiana.csv";
            csvReader = new BufferedReader(new FileReader(pathToCsv));
            String row = csvReader.readLine();
            truckingComp t = new truckingComp();
            int f = 0;
            while ((row = csvReader.readLine()) != null) {
                //System.out.println(row);
                t.truckingComp(row, ",");
                //System.out.println(t.toSQLInsertValues());
//                String SQL = "INSERT INTO TruckingCompanies"
//                + " VALUES ("+t.toSQLInsertValues()+");";
//                try {
//                    Connection con = DriverManager.getConnection("jdbc:sqlserver://wigstudentserver.database.windows.net:1433;database=IndianaTruckingCompanys;user=Wig@wigstudentserver;password=Run90009;encrypt=true;trustServerCertificate=false;hostNameInCertificate=*.database.windows.net;loginTimeout=30;");
//                    Statement stml = con.createStatement();
//                    stml.execute(SQL);
//                    con.close();
//                } catch (SQLException ex) {
//                    System.out.println(ex.getMessage());
//                }
                
                t.clearData();
                //System.out.println(t.getAddDate());
                break;
//                f++;
//                if(f>=3)break;
            }
        } catch (FileNotFoundException ex) {
        } catch (IOException ex) {
        } finally {
            try {
                csvReader.close();
            } catch (IOException ex) {
            }
        }
        
    }
    
}
