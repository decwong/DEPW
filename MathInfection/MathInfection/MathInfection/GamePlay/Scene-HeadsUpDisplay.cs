﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MathInfection
{
    class HeadsUpDisplay
    {
        private readonly Vector2 hudPosition;
        private string hudScore;
        private string hudHealth;

        public HeadsUpDisplay(Vector2 pos)
        {
            hudPosition = pos;
            hudScore = "";
            hudHealth = "";
        }

        public void update(Player p1, int eLeft)
        {
            int score = p1.Score;
            int health = p1.Health;

            hudScore = "         " + score;
            hudHealth = "        " + health;
        }

        public void draw(SpriteFont font, SpriteBatch batch, Texture2D score, Texture2D health)
        {
            batch.DrawString(font, hudScore, hudPosition, Color.White);
            batch.DrawString(font, hudHealth, new Vector2(hudPosition.X + 270, hudPosition.Y), Color.White);
            batch.Draw(score, new Vector2(hudPosition.X - 20, hudPosition.Y - 16), Color.White);
            batch.Draw(health, new Vector2(hudPosition.X + 220, hudPosition.Y - 17), Color.White);
        }
    }
}
