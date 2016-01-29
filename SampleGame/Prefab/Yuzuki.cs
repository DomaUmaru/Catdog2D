﻿using CatdogEngine.Playground.Object;
using Microsoft.Xna.Framework;
using CatdogEngine.Playground.Object.Component;
using CatdogEngine.Graphics;
using Microsoft.Xna.Framework.Graphics;
using CatdogEngine;
using Microsoft.Xna.Framework.Input;

namespace SampleGame.Prefab
{
	public class Yuzuki : Behavior, InputListener
	{
		private bool _up, _down, _left, _right;
		private readonly float SPEED = 300f;

		private int _hp;

		#region Properties
		public int HP { get { return _hp; } set { _hp = value; } }
		#endregion

		public Yuzuki()
		{
			InputManager.SetListener(this);
			_hp = 3;

			SpriteRenderer renderer = new SpriteRenderer("yuzuki", new Vector2(0.5f));
			AddComponent(renderer);

			Location location = new Location(16f, 32f);
			location.RelativePosition = new Vector2(9f, -36f);
			AddComponent(location);
		}

		public override void Start()
		{
			
		}

		public override void Update(GameTime gameTime)
		{
			float deltaTime = gameTime.ElapsedGameTime.Milliseconds / 1000f;
			float x = Transform.Position.X;
			float y = Transform.Position.Y;

            if (_up)
			{
				y = Transform.Position.Y + SPEED * deltaTime;
			}
			if(_down)
			{
				y = Transform.Position.Y - SPEED * deltaTime;
			}
			if(_left)
			{
				x = Transform.Position.X - SPEED * deltaTime;
			}
			if(_right)
			{
				x = Transform.Position.X + SPEED * deltaTime;
			}

			x = MathHelper.Clamp(x, -400, 400 - 44);
			y = MathHelper.Clamp(y, -240 + 72, 240);
			Transform.Position = new Vector2(x, y);
		}

		public void GetDamaged()
		{
			_hp--;
		}

		public void OnKeyDown(Keys key)
		{
			switch(key)
			{
				case Keys.Up:
					_up = true;
					break;

				case Keys.Down:
					_down = true;
					break;

				case Keys.Left:
					_left = true;
					break;

				case Keys.Right:
					_right = true;
					break;
			}
		}

		public void OnKeyUp(Keys key)
		{
			switch (key)
			{
				case Keys.Up:
					_up = false;
					break;

				case Keys.Down:
					_down = false;
					break;

				case Keys.Left:
					_left = false;
					break;

				case Keys.Right:
					_right = false;
					break;
			}
		}

		public void OnLeftMouseDown(int x, int y)
		{
			
		}

		public void OnLeftMouseUp(int x, int y)
		{
			
		}

		public void OnMouseMove(int x, int y)
		{
			
		}
	}
}
