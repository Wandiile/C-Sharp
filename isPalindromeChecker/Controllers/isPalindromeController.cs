using Microsoft.AspNetCore.Mvc;

namespace isPalindromeChecker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class isPalindromeController : ControllerBase
    {
        [HttpPost]
        public IActionResult PalindromeChecker([FromBody]string mom)
        {
            if (string.IsNullOrEmpty(mom))
            {
                return BadRequest("Input string is required");

            }
            string reversed = ReverseString(mom);
            bool isPalindrome = IsPalindrome(mom, reversed);

            return Ok(new { Reversed = reversed, IsPalindrome = isPalindrome });
        }
        private string ReverseString(string mom)
        {
            char[] alpha = mom.ToCharArray();
            Array.Reverse(alpha);
            return new string(alpha);
        }

        private bool IsPalindrome(string mom, string reversed)
        {
            return mom.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
