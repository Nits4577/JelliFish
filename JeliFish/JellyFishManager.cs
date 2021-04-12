namespace JeliFish
{
    public static class JellyFishManager
    {
        /// <summary>
        /// Get Last Position from string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetDirectionFromString(string s)
        {
            int cnt = GetStartDirection(s);
            string d = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                    cnt--;
                else if (s[i] == 'R')
                    cnt++;
                else if (s[i] == 'F')
                    continue;
            }
            if (cnt == 0)
            {
                return "LOST";
            }

            // if count is positive then result is clockwise direction
            if (cnt > 0)
            {
                if (cnt % 4 == 0)
                    d = "N";
                else if (cnt % 4 == 1)
                    d = "E";
                else if (cnt % 4 == 2)
                    d = "S";
                else if (cnt % 4 == 3)
                    d = "W";
            }

            // if count is negative the result  is anti-clockwise direction
            if (cnt < 0)
            {
                if (cnt % 4 == 0)
                    d = "N";
                else if (cnt % 4 == -1)
                    d = "W";
                else if (cnt % 4 == -2)
                    d = "S";
                else if (cnt % 4 == -3)
                    d = "E";
            }
            return d;
        }

        /// <summary>
        /// Get Direction from Given String
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetStartDirection(string s)
        {
            var cnt = 0;
            if (s.Contains("W"))
                cnt = 3;
            else if (s.Contains("S"))
                cnt = 2;
            else if (s.Contains("E"))
                cnt = 1;
            return cnt;
        }

        /// <summary>
        /// Removed inputs from String
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetValidString(string s)
        {
            var array = new char[] { 'N', 'W', 'S', 'E', 'R', 'L', 'F' };
            foreach (var item in array)
            {
                s = s.Replace(item, ' ');
            }
            return s;
        }
    }
}
