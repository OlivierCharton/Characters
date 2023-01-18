﻿namespace Kenedia.Modules.Characters.Classes.UI_Controls
{
    using Blish_HUD;
    using Blish_HUD.Content;
    using Blish_HUD.Controls;
    using Blish_HUD.Input;
    using Microsoft.Xna.Framework.Graphics;
    using Color = Microsoft.Xna.Framework.Color;
    using Rectangle = Microsoft.Xna.Framework.Rectangle;

    public class ImageTextureToggle : Control
    {
        public AsyncTexture2D ActiveTexture;
        public AsyncTexture2D InactiveTexture;
        public string ActiveText;
        public string InactiveText;

        private bool active;

        public Rectangle TextureRectangle;

        public Color ColorHovered = new Color(255, 255, 255, 255);
        public Color ColorActive = new Color(200, 200, 200, 255);
        public Color ColorInactive = new Color(200, 200, 200, 255);

        protected override void Paint(SpriteBatch spriteBatch, Rectangle bounds)
        {
            if (this.ActiveTexture != null)
            {
                var texture = this.active ? this.ActiveTexture : this.InactiveTexture != null ? this.InactiveTexture : this.ActiveTexture;

                spriteBatch.DrawOnCtrl(
                    this,
                    texture,
                    new Rectangle(bounds.Left, bounds.Top, bounds.Height, bounds.Height),
                    this.TextureRectangle == Rectangle.Empty ? texture.Bounds : this.TextureRectangle,
                    this.MouseOver ? this.ColorHovered : this.active ? this.ColorActive : this.ColorInactive,
                    0f,
                    default);
            }

            if (this.ActiveText != null)
            {
                var text = this.active ? this.ActiveText : this.InactiveText != null ? this.InactiveText : this.ActiveText;

                spriteBatch.DrawStringOnCtrl(
                    this,
                    text,
                    GameService.Content.DefaultFont14,
                    new Rectangle(bounds.Left + bounds.Height + 3, bounds.Top, bounds.Width - bounds.Height - 3, bounds.Height),
                    Color.White,
                    false,
                    false,
                    0,
                    HorizontalAlignment.Left,
                    VerticalAlignment.Middle);
            }
        }

        protected override void OnClick(MouseEventArgs e)
        {
            base.OnClick(e);
            this.active = !this.active;
        }
    }
}

