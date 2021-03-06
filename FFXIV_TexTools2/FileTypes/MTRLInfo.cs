﻿// FFXIV TexTools
// Copyright © 2017 Rafael Gonzalez - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using FFXIV_TexTools2.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FFXIV_TexTools2.Material
{
    public class MTRLInfo
    {
        public ObservableCollection<ComboBoxInfo> TextureMaps { get; set; } = new ObservableCollection<ComboBoxInfo>();

        public string MTRLPath { get; set; }
        public string SpecularPath { get; set; }
        public string MaskPath { get; set; }
        public string NormalPath { get; set; }
        public string DiffusePath { get; set; }

        public int MTRLOffset { get; set; }
        public int SpecularOffset { get; set; }
        public int MaskOffset { get; set; }
        public int NormalOffset { get;  set; }
        public int DiffuseOffset { get; set; }

        public byte[] ColorData { get; set; }
        public byte[] ColorFlags { get; set; }

        public bool Found { get; set; }

    }
}
