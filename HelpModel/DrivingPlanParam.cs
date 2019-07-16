using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 驾车路径规划请求参数
    /// </summary>
    public class DrivingPlanParam : GaoDeBaseParam
    {
        /// <summary>
        /// 出发点，允许最多传3个误差点，必填
        /// <para>经度在前，纬度在后，经纬度小数点后不得超过6位。格式为x1,y1|x2,y2|x3,y3</para>
        /// </summary>
        public string origin;
        /// <summary>
        /// 目的地，必填
        /// <para>经度在前，纬度在后，经度和纬度用","分割，经纬度小数点后不得超过6位。</para>
        /// </summary>
        public string destination;
        /// <summary>
        /// 出发点POIid，可选
        /// <para>当起点为POI时，建议填充此值。</para>
        /// </summary>
        public string originid;
        /// <summary>
        /// 目的地POIid，可选
        /// <para>当终点为POI时，建议填充此值。</para>
        /// </summary>
        public string destinationid;
        /// <summary>
        /// base:返回基本信息；all：返回全部信息
        /// </summary>
        public string extensions;
        /// <summary>
        /// 起点的poi类别，可选
        /// <para>当用户知道起点POI的类别时候，建议填充此值</para>
        /// </summary>
        public string origintype;
        /// <summary>
        /// 终点的poi类别，可选
        /// <para>当用户知道终点POI的类别时候，建议填充此值</para>
        /// </summary>
        public string destinationtype;
        /// <summary>
        /// 驾车选择策略，值与GaoDeConst.drivingStrategy对应，可选
        /// </summary>
        public int strategy;
        /// <summary>
        /// 途经点，小数点后不超过6位，坐标点之间用";"分隔，格式为x1,y1;x2,y2;x3,y3，可选
        /// <para>最大数目：16个坐标点。如果输入多个途径点，则按照用户输入的顺序进行路径规划</para>
        /// </summary>
        public string waypoints;
        /// <summary>
        /// 避让区域，可选
        /// <para>区域避让，支持32个避让区域，每个区域最多可有16个顶点，
        /// 坐标点之间用";"分隔，区域之间用"|"分隔。如果是四边形则有四个坐标点，如果是五边形则有五个坐标点；
        /// 同时传入避让区域及避让道路，仅支持避让道路；
        /// 避让区域不能超过81平方公里，否则避让区域会失效。</para>
        /// </summary>
        public string avoidpolygons;
        /// <summary>
        /// 避让道路名，可选
        /// <para>只支持一条避让道路</para>
        /// </summary>
        public string avoidroad;
        /// <summary>
        /// 用汉字填入车牌省份缩写，可选
        /// <para>用于判断是否限行</para>
        /// </summary>
        public string province;
        /// <summary>
        /// 填入除省份及标点之外，车牌的字母和数字（需大写），可选
        /// <para>用于判断限行相关，支持6位传统车牌和7位新能源车牌。</para>
        /// </summary>
        public string number;
        /// <summary>
        /// 车辆类型，值与GaoDeConst.carType对应，可选
        /// </summary>
        public int cartype;
        /// <summary>
        /// 在路径规划中，是否使用轮渡，可选
        /// <para>0:使用渡轮(默认) 1:不使用渡轮</para>
        /// </summary>
        public int ferry;
        /// <summary>
        /// 是否返回路径聚合信息，可选
        /// <para>false:不返回路径聚合信息 true:返回路径聚合信息，在steps上层增加roads做聚合</para>
        /// </summary>
        public bool roadaggregation;
    }
}
