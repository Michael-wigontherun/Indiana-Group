package com.indiana.chameleon;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import java.util.*;
import org.springframework.web.bind.annotation.*;
import java.sql.*;
import java.io.*;

@RestController
@SpringBootApplication
public class DemoApplication {

	public static void main(String[] args) {
		SpringApplication.run(DemoApplication.class, args);
	}
	//returns the list of chameleon companies
	@RequestMapping(value = "/", method = RequestMethod.GET)
	public List<LiquidTable> compareTable() {
		//list of liquidatedTable
		List response = new ArrayList<LiquidTable>();
		//list of Trucking Table
		List response2 = new ArrayList<TruckingTable>();
		//list to hold chameleon companies
		List response3 = new ArrayList<Chameleon>();
		Connection conn;
		String SQL;
		SQL = "select * from LiquidatedCompanys";
		LiquidTable table = new LiquidTable();
		TruckingTable truck = new TruckingTable();
		Chameleon cham = new Chameleon();
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            conn = DriverManager.getConnection(ConnectionString.connectionString);

            Statement stmt = conn.createStatement();
			ResultSet records = stmt.executeQuery(SQL);
			//fills liquidtable list
			while(records.next()){
				table = new LiquidTable();
				table.USDOT = records.getString("USDOT");
				table.LegalName = records.getString("LegalName");
				table.DBAName = records.getString("DBAName");
				table.Address = records.getString("Address");
				table.OOSReason = records.getString("OOSReason");
				table.OOSDate = records.getString("OOSDate");
				table.Status = records.getString("Status");
				table.GeoLocation = records.getString("GeoLocation");
				table.adminID = records.getString("addminID");
				response.add(table);
			}
			SQL = "select USDOT, LegalName, DBAName, MCS150_DATE_, PHY_STREET_, PHY_CITY_, PHY_STATE_, PHY_ZIP_, GeoLocation from TruckingCompanies";
			ResultSet records2 = stmt.executeQuery(SQL);
			//fills trucking table list
			while(records2.next()){
				truck = new TruckingTable();
				truck.USDOT = records2.getString("USDOT");
				truck.LegalName = records2.getString("LegalName");
				truck.DBAName = records2.getString("DBAName");
				truck.MCS150_Date = records2.getString("MCS150_Date_");
				truck.PHY_STREET_ = records2.getString("PHY_STREET_");
				truck.PHY_CITY_ = records2.getString("PHY_CITY_");
				truck.PHY_STATE_ = records2.getString("PHY_STATE_");
				truck.PHY_ZIP_ = records2.getString("PHY_ZIP_");
				truck.GeoLocation = records2.getString("GeoLocation");
				response2.add(truck);
				//checks for chameleon company and adds it to list
				for(int x = 0; x < response.size(); x++){
					cham = new Chameleon();
					//If statements controll the parameters for chameleon
					//makes sure legal names are different
					if (!truck.LegalName.equals(((LiquidTable) response.get(x)).LegalName)) {
						//checks if geolocation matches and is not null
						if((truck.GeoLocation.equals(((LiquidTable) response.get(x)).GeoLocation)) && !truck.GeoLocation.equals("-NA-")){
							//checks to see if the OOSReason falls under suspitious reasons
							if(((LiquidTable) response.get(x)).OOSReason.equals("New Entrant Revoked - Expedited Actions")){
								cham.USDOT = truck.USDOT;
								cham.adminID = "3/12/2020";
								cham.percent = "90%";
								response3.add(cham);
							}
							else{
								cham.USDOT = truck.USDOT;
								cham.adminID = "3/12/2020";
								cham.percent = "40%";
								response3.add(cham);
							}
						}
						//checks to make sure geolocation is null
						if(truck.GeoLocation.equals("-NA-")){
							//checks to see if liquid table address contains street from trucking table
							if(((LiquidTable) response.get(x)).Address.contains(truck.PHY_STREET_)){
								cham.USDOT = truck.USDOT;
								cham.adminID = "3/12/2020";
								cham.percent = "20%";
								response3.add(cham);
							}
						}
					}
				}
			}
		} 
		catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return response3;
	}

}
