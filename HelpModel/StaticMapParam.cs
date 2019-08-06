using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 静态地图基础参数
    /// </summary>
    public class StaticMapParam : GaoDeBaseParam
    {
        /// <summary>
        /// 地图中心点（规则：经度和纬度用","分隔 经纬度小数点后不得超过6位），部分条件必填
        /// <para>如果有标注markers/标签labels/折线paths等覆盖物，则中心点（location）和地图级别（zoom）可选填。</para>
        /// </summary>
        public string location;
        /// <summary>
        /// 地图级别（地图缩放级别:[1,17]），可选
        /// <para>如果有标注markers/标签labels/折线paths等覆盖物，则中心点（location）和地图级别（zoom）可选填。</para>
        /// </summary>
        public int zoom;
        /// <summary>
        /// 地图大小，可选
        /// <para>图片宽度*图片高度。最大值为1024*1024，默认400*400</para>
        /// </summary>
        public string size;
        /// <summary>
        /// 普通/高清，可选，默认1
        /// <para>1:返回普通图；2:调用高清图，图片高度和宽度都增加一倍，zoom也增加一倍（当zoom为最大值时，zoom不再改变）</para>
        /// </summary>
        public int scale = 1;
        /// <summary>
        /// 标注标注最大数10个
        /// </summary>
        public MapMarker markers;
        /// <summary>
        /// 标签最大数10个
        /// </summary>
        public MapLabel labels;
        /// <summary>
        /// 折线和多边形最大数4个
        /// </summary>
        public MapPath paths;
        /// <summary>
        /// 交通路况标识，可选，默认0
        /// <para>底图是否展现实时路况：0=不展现；1=展现</para>
        /// </summary>
        public int traffic = 0;
    }

    /// <summary>
    /// 地图的标注
    /// </summary>
    public class MapMarker
    {
        /// <summary>
        /// 标识的大小
        /// </summary>
        public MarkerSize size;
        /// <summary>
        /// 十六禁止表示的颜色
        /// <para>例如：0x000000 black,0x008000 green,0x800080 purple,0xFFFF00 yellow,0x0000FF blue,0x808080 gray,0xffa500 orange,0xFF0000 red,0xFFFFFF white</para>
        /// </summary>
        public string color;
        /// <summary>
        /// [0-9]、[A-Z]、[单个中文字] 当size为small时，图片不展现标注名
        /// </summary>
        public string label;
        /// <summary>
        /// 标注的位置
        /// <para>经度和纬度用","分隔，经纬度小数点后不得超过6位，多个标注位置用";"分隔</para>
        /// </summary>
        public string location;

        private List<MapMarker> mapMarkerList = new List<MapMarker>();

        /// <summary>
        /// 添加单个其他标注
        /// </summary>
        /// <param name="marker">单个其他标注</param>
        public void Add(MapMarker marker)
        {
            if (mapMarkerList.Count == 0) mapMarkerList.Add(this);
            if (!mapMarkerList.Contains(marker))
                mapMarkerList.Add(marker);
        }

        /// <summary>
        /// 添加多个其他标注
        /// </summary>
        /// <param name="markerList">多个其他标注</param>
        public void AddRange(IEnumerable<MapMarker> markerList)
        {
            if (mapMarkerList.Count == 0) mapMarkerList.Add(this);
            mapMarkerList.AddRange(markerList);
            mapMarkerList = mapMarkerList.Distinct().ToList();
        }

        /// <summary>
        /// 序列化为符合高德接口参数格式的字符串
        /// </summary>
        /// <returns>高德接口参数格式的字符串</returns>
        public override string ToString()
        {
            if (mapMarkerList.Count == 0) mapMarkerList.Add(this);
            StringBuilder strBuilder = new StringBuilder();
            foreach(MapMarker marker in mapMarkerList)
            {
                if (mapMarkerList.IndexOf(marker) > 0)
                    strBuilder.Append("|");
                strBuilder.AppendFormat("{0},{1},{2}:{3}", marker.size, marker.color, marker.label, marker.location);
            }
            return strBuilder.ToString();
        }
    }

    /// <summary>
    /// 地图标识的大小
    /// </summary>
    public enum MarkerSize
    {
        /// <summary>
        /// 小尺寸
        /// </summary>
        small,
        /// <summary>
        /// 中等
        /// </summary>
        mid,
        /// <summary>
        /// 大尺寸
        /// </summary>
        large
    }

    /// <summary>
    /// 地图的标签
    /// </summary>
    public class MapLabel
    {
        /// <summary>
        /// 标签内容，字符最大数目为15
        /// </summary>
        public string content;
        /// <summary>
        /// 字体
        /// <para>0：微软雅黑；1：宋体；2：Times New Roman;3：Helvetica</para>
        /// </summary>
        public int font;
        /// <summary>
        /// 是否加粗
        /// <para>0：非粗体；1：粗体</para>
        /// </summary>
        public int bold;
        /// <summary>
        /// 字体大小，可选值[1,72]
        /// </summary>
        public int fontSize = 10;
        /// <summary>
        /// 字体颜色，取值范围：[0x000000, 0xffffff]
        /// </summary>
        public string fontColor;
        /// <summary>
        /// 背景色，取值范围：[0x000000, 0xffffff]
        /// </summary>
        public string background;
        /// <summary>
        /// 标签的位置
        /// <para>经度和纬度用","分隔，经纬度小数点后不得超过6位，多个标注位置用";"分隔</para>
        /// </summary>
        public string location;

        private List<MapLabel> mapLabelList = new List<MapLabel>();

        /// <summary>
        /// 添加单个其他标签
        /// </summary>
        /// <param name="marker">单个其他标签</param>
        public void Add(MapLabel marker)
        {
            if (mapLabelList.Count == 0) mapLabelList.Add(this);
            if (!mapLabelList.Contains(marker))
                mapLabelList.Add(marker);
        }

        /// <summary>
        /// 添加多个其他标签
        /// </summary>
        /// <param name="markerList">多个其他标签</param>
        public void AddRange(IEnumerable<MapLabel> markerList)
        {
            if (mapLabelList.Count == 0) mapLabelList.Add(this);
            mapLabelList.AddRange(markerList);
            mapLabelList = mapLabelList.Distinct().ToList();
        }

        /// <summary>
        /// 序列化为符合高德接口参数格式的字符串
        /// </summary>
        /// <returns>高德接口参数格式的字符串</returns>
        public override string ToString()
        {
            if (mapLabelList.Count == 0) mapLabelList.Add(this);
            StringBuilder strBuilder = new StringBuilder();
            foreach (MapLabel label in mapLabelList)
            {
                if (mapLabelList.IndexOf(label) > 0)
                    strBuilder.Append("|");
                strBuilder.AppendFormat("{0},{1},{2},{3},{4},{5}:{6}", label.content, label.font, label.bold, label.fontSize, label.fontColor, label.background, label.location);
            }
            return strBuilder.ToString();
        }
    }

    /// <summary>
    /// 地图的折线
    /// </summary>
    public class MapPath
    {
        /// <summary>
        /// 线条粗细，可选值： [2,15]
        /// </summary>
        public int weight = 2;
        /// <summary>
        /// 折线的颜色，选值范围：[0x000000, 0xffffff]
        /// <para>例如：0x000000 black,0x008000 green,0x800080 purple,0xFFFF00 yellow,0x0000FF blue,0x808080 gray,0xffa500 orange,0xFF0000 red,0xFFFFFF white</para>
        /// </summary>
        public string color;
        /// <summary>
        /// 透明度
        /// <para>可选值[0,1]，小数后最多2位，0表示完全透明，1表示完全不透明</para>
        /// </summary>
        public decimal transparency = 1;
        /// <summary>
        /// 多边形的填充颜色
        /// </summary>
        public string fillcolor;
        /// <summary>
        /// 填充面透明度
        /// <para>可选值[0,1]，小数后最多2位，0表示完全透明，1表示完全不透明</para>
        /// </summary>
        public decimal fillTransparency = new decimal(0.5);
        /// <summary>
        /// 标注的位置
        /// <para>经度和纬度用","分隔，经纬度小数点后不得超过6位，多个标注位置用";"分隔</para>
        /// </summary>
        public string location;

        private List<MapPath> mapPathList = new List<MapPath>();

        /// <summary>
        /// 添加单个其他折线
        /// </summary>
        /// <param name="marker">单个其他折线</param>
        public void Add(MapPath mapPath)
        {
            if (mapPathList.Count == 0) mapPathList.Add(this);
            if (!mapPathList.Contains(mapPath))
                mapPathList.Add(mapPath);
        }

        /// <summary>
        /// 添加多个其他折线
        /// </summary>
        /// <param name="markerList">多个其他折线</param>
        public void AddRange(IEnumerable<MapPath> pathList)
        {
            if (mapPathList.Count == 0) mapPathList.Add(this);
            mapPathList.AddRange(pathList);
            mapPathList = mapPathList.Distinct().ToList();
        }

        /// <summary>
        /// 序列化为符合高德接口参数格式的字符串
        /// </summary>
        /// <returns>高德接口参数格式的字符串</returns>
        public override string ToString()
        {
            if (mapPathList.Count == 0) mapPathList.Add(this);
            StringBuilder strBuilder = new StringBuilder();
            foreach (MapPath mapPath in mapPathList)
            {
                if (mapPathList.IndexOf(mapPath) > 0)
                    strBuilder.Append("|");
                strBuilder.AppendFormat("{0},{1},{2},{3},{4}:{5}", mapPath.weight, mapPath.color, mapPath.transparency, mapPath.fillcolor, mapPath.fillTransparency, mapPath.location);
            }
            return strBuilder.ToString();
        }
    }
}
