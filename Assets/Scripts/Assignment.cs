using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         As01_CheckNumberSign();
        // As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");
        throw new System.NotImplementedException();
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        if (as02Day == 1)
        {
            Debug.Log("Monday");
        }
        else if (as02Day == 2)
        {
            Debug.Log("Tuesday");
        }
        else if (as02Day == 3)
        {
            Debug.Log("Wednesday");
        }
        else if (as02Day == 4)
        {
            Debug.Log("Thursday");
        }
        else if (as02Day == 5)
        {
            Debug.Log("Friday");
        }
        else if (as02Day == 6)
        {
            Debug.Log("Saturday");
        }
        else if (as02Day == 7)
        {
            Debug.Log("Sunday");
        }
        else
        {
            Debug.Log("Invalid day");
        }
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        throw new System.NotImplementedException();
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");
        throw new System.NotImplementedException();
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        if (as04Score >= 80 && as04Score < 70)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70 && as04Score < 80)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60 && as04Score < 70)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50 && as04Score < 60)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");
        throw new System.NotImplementedException();
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        if (as05Year % 400 == 0)
        {
            Debug.Log("True"); 
        }
            
        else if (as05Year % 100 == 0)
        { 
            Debug.Log("False");
        }
    
        else if (as05Year % 4 == 0)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }    
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");
        throw new System.NotImplementedException();
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public double result;
    public void As06_Calculate()
    {
        switch (as06Op)
        {
            case '+': result = as06Num1 + as06Num2; break;
            case '/':
                if (as06Num2 == 0)
                {
                    Debug.Log("Error: Cannot divide by zero.");
                }
                else
                {
                    result = as06Num1 / as06Num2; break;
                }
            default:
                Debug.Log("Invalid operator. Please use +, -, *, or /.");
                return;
        }
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");
        throw new System.NotImplementedException();
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        if (as07Month == 1 || as07Month == 2 || as07Month == 12)
        {
            Debug.Log("Winter");
        }
        else if (as07Month == 3 || as07Month == 4 || as07Month == 5)
        {
            Debug.Log("Spring");
        }
        else if (as07Month == 6 || as07Month == 7 || as07Month == 8)
        {
            Debug.Log("Summer");
        }
        else if (as07Month == 9 || as07Month == 10 || as07Month == 11)
        {
            Debug.Log("Fall");
        }
        else
        {
            Debug.Log("Not a month");
        }
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        throw new System.NotImplementedException();
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if (as08Quantity <= 0)
        {
            Debug.Log("สินค้าหมด");
        }
        else if (as08Quantity > 0)
        {
            if (as08Payment >= as08Price)
            {
                Debug.Log("คุณได้รับสินค้าแล้ว");
                if(as08Price > as08Payment)
                {
                    +as08Price - as08Payment;
                    Debug.Log("คุณได้รับเงินทอน" as08Price - as08Payment "บาท");
                }
            }
            else if (as08Payment < as08Price)
            {
                Debug.Log("คุณมีเงินไม่พอ");
            }
        }
        throw new System.NotImplementedException();
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        if (as09ComputerChoice == 1)
        {
            if (as09UserChoice == 1)
            {
                Debug.Log("Tie");
            }
            else if (as09UserChoice == 2)
            {
                Debug.Log("Win");
            }
            else if (as09UserChoice == 3)
            {
                Debug.Log("Lose");
            }
            else
            {
                Debug.Log("Choose");
            }
        }
        else if (as09ComputerChoice == 2)
        {
            if (as09UserChoice == 1)
            {
                Debug.Log("Lose");
            }
            else if (as09UserChoice == 2)
            {
                Debug.Log("Tie");
            }
            else if (as09UserChoice == 3)
            {
                Debug.Log("Win");
            }
            else
            {
                Debug.Log("Choose");
            }
        }
        else if (as09ComputerChoice == 3)
        {
            if (as09UserChoice == 1)
            {
                Debug.Log("Win");
            }
            else if (as09UserChoice == 2)
            {
                Debug.Log("Lose");
            }
            else if (as09UserChoice == 3)
            {
                Debug.Log("Tie");
            }
            else
            {
                Debug.Log("Choose");
            }
        }
        throw new System.NotImplementedException();
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        throw new System.NotImplementedException();
    }
}
