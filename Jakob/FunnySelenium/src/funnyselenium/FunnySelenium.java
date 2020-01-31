/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package funnyselenium;
import java.util.List;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedCondition;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.openqa.selenium.chrome.ChromeDriver;
/**
 *
 * @author shatt
 */
public class FunnySelenium {
    public static WebDriver driver;
    public static void main(String[] args) {
        System.setProperty("webdriver.chrome.driver", "D:\\Selenium\\chromeDriver\\chromedriver.exe");
        System.out.println("Test Iniatiated");
        driver = new ChromeDriver();
        driver.get("https://li-public.fmcsa.dot.gov/LIVIEW/pkg_oos_process.prc_list?pv_vpath=LIVIEW&pv_show_all=N&pn_dotno=&pn_docket=&pv_legalname=&s_state=INUS");
        WebElement simpleTable = driver.findElement(By.xpath("/html/body/font/table[2]/tbody")); 
        // Get all rows 
        List<WebElement> rows = simpleTable.findElements(By.tagName("tr")); 
        //Variables
        StringBuilder data = new StringBuilder();
        StringBuilder data2 = new StringBuilder();
        String var = "";
        String var1 = "";
        String var2 = "";
        String var3 = "";
        String var4 = "";
        String var5 = "";
        //runs through the rows
        for (WebElement row : rows) { 
            List<WebElement> cols = row.findElements(By.tagName("td"));
            List<WebElement> cols2 = row.findElements(By.tagName("th"));
            //collects data from columns
            for (WebElement col : cols) {
                data.append(col.getText() + "\t");
            }
            for (WebElement col2 : cols2) {
                data2.append(col2.getText() + "\t");
            }
            String[] array = data.toString().replaceAll("\n", "").split("\t", 5);
            String[] array2 = data2.toString().replaceAll("\n", "").split("\t");
            //ignores row 1
            if(array.length > 1 && array2.length <=1){
                //separates data into separate variables
                var = (array2[0].replaceAll("\t", ""));
                var1 = (array[0].replaceAll("\t", ""));
                var2 = (array[1].replaceAll("\t", ""));
                var3 = (array[2].replaceAll("\t", ""));
                var4 = (array[3].replaceAll("\t", ""));
                var5 = (array[4].replaceAll("\t", ""));
                //prints data
                System.out.print(var + " | " + var1 + " | " + var2 + " | " + var3 + " | " + var4 + " | " + var5 + " | ");
            }
            System.out.println();
            data = null;
            data2 = null;
            data = new StringBuilder();
            data2 = new StringBuilder();
        }
        //for testing a single line
        //System.out.print(var + " | " + var1 + " | " + var2 + " | " + var3 + " | " + var4 + " | " + var5 + " | ");
        driver.close();
    }
    
}
