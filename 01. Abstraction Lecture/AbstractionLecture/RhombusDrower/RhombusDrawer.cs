using System;
using System.Collections.Generic;
using System.Text;

namespace RhombusDrower
{
    class RhombusDrawer
    {
        public string Draw(int n)
        {
            StringBuilder sb = new StringBuilder();
            this.DrawTopPart(sb, n);
            this.DrawLineOfStars(sb, n);
            this.DrawBottomPart(sb, n);

            return sb.ToString();
        }

        private void DrawLineOfStars(StringBuilder sb, int numberOfStars)
        {
            for (int stars = 0; stars < numberOfStars; stars++)
            {
                sb.Append('*');

                if (stars < numberOfStars - 1)
                {
                    sb.Append(' ');
                }
            }

            sb.AppendLine();
        }

        private void DrawTopPart(StringBuilder sb, int n)
        {
            for (int i = 1; i < n; i++)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(sb, i);
            }
        }

        private void DrawBottomPart(StringBuilder sb, int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(sb, i);
            }

            Console.WriteLine(sb);

        }
    }
}
