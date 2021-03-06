/*
 * RequestType.cs
 * UnityHTTP
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 * Authors: Andy Burke
 * Copyright: Copyright (c) 2015 andyburke
 * License: GPL
 */

using System;

namespace UnityHTTP.Enums {
	public class RequestType {

		public string Value { get; set; }

		private RequestType (string value) { 
			Value = value; 
		}

		public static RequestType GET  { get { return new RequestType("GET"); }}
		public static RequestType POST { get { return new RequestType("POST"); }}
	}
}
