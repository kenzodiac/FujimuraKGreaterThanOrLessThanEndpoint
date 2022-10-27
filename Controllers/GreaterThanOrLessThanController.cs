//Kenneth Fujimura
//Date Revised: 10-25-2022
//Greater Than Or Less Than - Endpoint
//This is a web API program that emulates our original "Greater Than Or Less Than" mini challenge from the coding combine, refactored to work as a website that takes in inputs through its URL.
//Peer Reviewed By: Mark A Ramirez The program works and can even take decimals as the input which is very nice much expected from ken.

using Microsoft.AspNetCore.Mvc;

namespace FujimuraKGreaterThanOrLessThan.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterThanOrLessThanController : ControllerBase
{
    [HttpGet]
    [Route("GreaterThan/{num1}/{num2}")]

    public string GreaterThan(double num1, double num2){
        if (num1 > num2) {
            return $"{num1} is greater than {num2}.";
        } else if (num2 > num1){
            return $"{num1} is less than {num2}.";
        } else {
            return $"{num1} is the same as {num2}";
        }
    }
}
