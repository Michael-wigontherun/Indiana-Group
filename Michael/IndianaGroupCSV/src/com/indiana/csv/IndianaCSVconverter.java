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
        SystemKey k = new SystemKey();
        truckingComp t = new truckingComp(k.Key);
        try {
            String pathToCsv = "F:\\IndianaGroup\\Indiana-Group\\Michael\\indiana.csv";
            csvReader = new BufferedReader(new FileReader(pathToCsv));
            String row = csvReader.readLine();
            int f = 0;
            while ((row = csvReader.readLine()) != null) {
                //System.out.println(row);
                t.csvRowDataSet(row, ",","update");
                String SQL = String.format("INSERT INTO TruckingCompanies VALUES (%s);", t.toSQLInsertValues());
                System.out.println(SQL);
//                try {
//                    Connection con = DriverManager.getConnection(k.azureConnectionString);
//                    Statement stml = con.createStatement();
//                    stml.execute(SQL);
//                    con.close();
//                } catch (SQLException ex) {
//                    System.out.println(ex.getMessage());
//                }
                
                t.clearData();
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
