﻿/*
 * Copyright 2023 Peter Han
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 * and associated documentation files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
 * BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using Newtonsoft.Json;
using PeterHan.PLib.Options;

namespace PeterHan.DeselectNewMaterials {
	/// <summary>
	/// The options class used for Deselect New Materials.
	/// </summary>
	[ModInfo("https://github.com/peterhaneve/ONIMods", "preview.png")]
	[JsonObject(MemberSerialization.OptIn)]
	public sealed class DeselectMaterialsOptions {
		[Option("Food Storage Accepts By Default", "Sets the default setting on Ration Boxes and Refrigerators to Accepts New Materials.")]
		[JsonProperty]
		public bool IgnoreFoodBoxes { get; set; }

		public DeselectMaterialsOptions() {
			IgnoreFoodBoxes = false;
		}

		public override string ToString() {
			return string.Format("DeselectMaterialsOptions[ignoreFood={0}]", IgnoreFoodBoxes);
		}
	}
}
