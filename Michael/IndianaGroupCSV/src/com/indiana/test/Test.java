/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.indiana.test;

import com.indiana.SystemKey;

import javax.script.ScriptEngine;
import javax.script.ScriptEngineManager;
import javax.script.ScriptException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;


/**
 *
 * @author Owner
 */
public class Test {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Connection connection = null;
        Statement insertStmt = null;
        Statement selectStmt = null;
        try
        {
            connection = DriverManager.getConnection(SystemKey.azureConnectionString);
            selectStmt = connection.createStatement();
            ResultSet rs = selectStmt.executeQuery("SELECT * from TruckingCompanies where usdot = '1000283'");
            if(!rs.next()){
                System.out.println("Is empty");
            }
            else System.out.println(rs.getString(1));
        }
        catch (Exception e) {
            e.printStackTrace();
        }finally {
            try {
                selectStmt.close();
                connection.close();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }


}
