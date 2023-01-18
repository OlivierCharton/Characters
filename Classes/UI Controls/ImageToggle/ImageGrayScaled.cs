﻿namespace Kenedia.Modules.Characters.Classes.UI_Controls
{
    using Blish_HUD;
    using Blish_HUD.Content;
    using Blish_HUD.Controls;
    using Microsoft.Xna.Framework.Graphics;
    using Color = Microsoft.Xna.Framework.Color;
    using Rectangle = Microsoft.Xna.Framework.Rectangle;

    public class ImageGrayScaled : Control
    {
        public bool UseGrayScale = true;

        private Texture2D _grayScaleTexture;
        private AsyncTexture2D _texture;

        public AsyncTexture2D Texture
        {
            get => this._texture;
            set
            {
                this._texture = value;
                this._texture.TextureSwapped += this.Texture_TextureSwapped;
                if (value != null)
                {
                    this._grayScaleTexture = this.ToGrayScaledPalettable(value.Texture);
                }
            }
        }

        private void Texture_TextureSwapped(object sender, ValueChangedEventArgs<Texture2D> e)
        {
            this._grayScaleTexture = this.ToGrayScaledPalettable(this._texture);
            this._texture.TextureSwapped -= this.Texture_TextureSwapped;
        }

        public static Color[] palColorArray = new Color[]
            {
                    new Color(191, 191, 191),
                    new Color(000, 000, 000),
                    new Color(255, 255, 255),
                    new Color(255, 000, 000),
                    new Color(191, 000, 000),
                    new Color(255, 191, 191),
                    new Color(255, 255, 000),
                    new Color(191, 191, 000),
                    new Color(255, 255, 191),
                    new Color(000, 255, 000),
                    new Color(000, 191, 000),
                    new Color(191, 255, 191),
                    new Color(000, 255, 255),
                    new Color(000, 191, 191),
                    new Color(191, 255, 255),
                    new Color(000, 000, 255),
                    new Color(000, 000, 191),
                    new Color(191, 191, 255),
                    new Color(255, 000, 255),
                    new Color(191, 000, 191),
                    new Color(255, 191, 255),
            };

        public Texture2D ToGrayScaledPalettable(Texture2D original)
        {
            // make an empty bitmap the same size as original
            Color[] colors = new Color[original.Width * original.Height];
            original.GetData<Color>(colors);
            Color[] destColors = new Color[original.Width * original.Height];
            Texture2D newTexture;

            using (var device = GraphicsService.Graphics.LendGraphicsDeviceContext())
            {
                newTexture = new Texture2D(device.GraphicsDevice, original.Width, original.Height);
            }

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    // get the pixel from the original image
                    int index = i + (j * original.Width);
                    Color originalColor = colors[index];

                    // create the grayscale version of the pixel
                    float maxval = .3f + .59f + .11f + .79f;
                    float grayScale = (originalColor.R / 255f * .3f) + (originalColor.G / 255f * .59f) + (originalColor.B / 255f * .11f) + (originalColor.A / 255f * .79f);
                    grayScale = grayScale / maxval;

                    destColors[index] = new Color(grayScale, grayScale, grayScale, originalColor.A);
                }
            }
            newTexture.SetData<Color>(destColors);
            return newTexture;
        }

        private Rectangle _textureRectangle = Rectangle.Empty;
        public Rectangle SizeRectangle;

        public Rectangle TextureRectangle
        {
            get => this._textureRectangle;
            set => this._textureRectangle = value;
        }

        private bool _active = false;

        public bool Active
        {
            get => this._active;
            set => this._active = value;
        }

        public Color ColorHovered = new Color(255, 255, 255, 255);
        public Color ColorActive = new Color(200, 200, 200, 200);
        public Color ColorInActive = new Color(175, 175, 175, 255);
        public float Alpha = 0.25f;
        static public Color DefaultColorHovered = new Color(255, 255, 255, 255);
        static public Color DefaultColorActive = new Color(200, 200, 200, 200);
        static public Color DefaultColorInActive = new Color(175, 175, 175, 255);

        public void ResetColors()
        {
            this.ColorHovered = DefaultColorHovered;
            this.ColorActive = DefaultColorActive;
            this.ColorInActive = DefaultColorInActive;
        }

        protected override void Paint(SpriteBatch spriteBatch, Rectangle bounds)
        {
            if (this._texture != null)
            {
                spriteBatch.DrawOnCtrl(
                    this,
                    this.UseGrayScale && !this._active && !this.MouseOver ? this._grayScaleTexture : this._texture,
                    this.SizeRectangle != Rectangle.Empty ? this.SizeRectangle : bounds,
                    this._textureRectangle == Rectangle.Empty ? this._texture.Bounds : this._textureRectangle,
                    this.MouseOver ? this.ColorHovered : this._active ? this.ColorActive : this.ColorInActive * (this.UseGrayScale ? 0.5f : this.Alpha),
                    0f,
                    default);
            }
        }
    }
}

