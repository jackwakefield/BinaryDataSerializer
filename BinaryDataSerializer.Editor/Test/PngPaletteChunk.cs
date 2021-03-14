using System.Collections.Generic;

namespace BinaryDataSerializer.Editor.Test
{
    public class PngPaletteChunk : PngChunk
    {
        public List<PngRgb> PaletteEntry { get; set; }
    }
}
