/*
===============================================================================
    Copyright (C) 2020 Ilya Lyakhovets
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
===============================================================================
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IlyaLts.Tetris
{
    public class Block : MonoBehaviour
    {
        public void Move(int x, int y)
        {
            Rect rect = GetComponent<RectTransform>().rect;
            Vector3 pos = GetComponent<Transform>().position;
            GetComponent<Transform>().position = new Vector3(pos.x + rect.width * x, pos.y + rect.height * y);
        }
    }
}
