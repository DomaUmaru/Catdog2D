﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatdogEngine.Playground.Object {
	/// <summary>
	/// World에 존재하는 카메라. Rotation은 사용하지 않는다.
	/// Behavior와 Camera간의 상대적 위치, 그리고 Zoom 값을 통해 화면에 그려질 위치가 결정된다.
	/// 모든 World는 자신의 Camera를 반드시 하나 가진다.
	/// </summary>
	public class Camera : Behavior{
		private float _zoom;					// 줌

		#region Properties
		public float Zoom {
			get { return _zoom; }
			set {
				if (value < 1) _zoom = 1f;
				else _zoom = value;
			}
		}
		#endregion

		public override void Start() {

		}

		public override void Update() {

		}
	}
}