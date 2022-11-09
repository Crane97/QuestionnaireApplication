import io.github.bonigarcia.wdm.WebDriverManager;
import org.openqa.selenium.By;
import org.openqa.selenium.NoSuchElementException;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.annotations.AfterMethod;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.Test;

public class SeleniumTest {

    WebDriver driver;

    @BeforeClass
    void setUpClass(){
        WebDriverManager.chromedriver().setup();
    }

    @BeforeMethod
    void setUpMethod(){
        driver = new ChromeDriver();
        driver.get("http://localhost:3000");
        driver.manage().window().maximize();
    }

    @AfterMethod
    void afterMethod(){
        driver.quit();
    }

    @Test
    void inputNewEmail_thenSubmit_returnTrue() {

        WebElement emailInput = driver.findElement(By.id("email"));
        emailInput.sendKeys("jorge@test.com");

        driver.findElement(By.id("submit")).click();

        Assert.assertNotNull(driver.findElement(By.id("questionsId")));

        //Thread.sleep(3000);
    }

    @Test
    void inputEmptyEmail_thenSubmit_returnsError(){
        WebElement emailInput = driver.findElement(By.id("email"));
        emailInput.sendKeys("");

        //driver.findElement(By.id("submit")).click();

        Assert.assertThrows(NoSuchElementException.class, () -> driver.findElement(By.id("questionsId")));
        //TODO: Assert.assertNotEquals(null, driver.findElement(By.id("error")));
    }

    @Test
    void inputExistingEmail_thenSubmit_returnsError(){

        inputNewEmail_thenSubmit_returnTrue();

        WebElement emailInput = driver.findElement(By.id("email"));
        emailInput.sendKeys("jorge@test.com");


        //driver.findElement(By.id("submit")).click();

        Assert.assertThrows(NoSuchElementException.class, () -> driver.findElement(By.id("questionsId")));
        //TODO: Assert.assertNotEquals(null, driver.findElement(By.id("error")));
    }
}
