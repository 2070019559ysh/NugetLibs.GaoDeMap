using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.HelpModel
{
    /// <summary>
    /// 货车路径规划请求参数
    /// </summary>
    public class TruckPlanParam : GaoDeBaseParam
    {
        /// <summary>
        /// 出发点经纬度，必填
        /// <para>经度在前，纬度在后，经纬度小数点后不得超过6位。格式为x,y</para>
        /// </summary>
        public string origin;
        /// <summary>
        /// 出发POI的唯一编号，可选
        /// <para>当起点为POI时，建议填充此值。填充此值以后，会影响路径规划的结果，举例来说，当起点的经纬度在高架桥上面</para>
        /// </summary>
        public string originid;
        /// <summary>
        /// 出发POI的类型，可选
        /// <para>当起点为POI时，建议填充此值。</para>
        /// </summary>
        public string originidtype;
        /// <summary>
        /// 目的地经纬度，必填
        /// <para>经度在前，纬度在后，经纬度小数点后不得超过6位。格式为x,y</para>
        /// </summary>
        public string destination;
        /// <summary>
        /// 终点POI的唯一编号，可选
        /// <para>当终点为POI时，建议填充此值。填充此值以后，会影响路径规划的结果，举例来说，当终点的经纬度在高架桥上面</para>
        /// </summary>
        public string destinationid;
        /// <summary>
        /// 终点POI的类型 
        /// <para>当起点为POI时，建议填充此值。</para>
        /// </summary>
        public string destinationtype;
        /// <summary>
        /// 设备唯一编号，可选
        /// <para>安卓的imei；苹果的idfa</para>
        /// </summary>
        public string diu;
        /// <summary>
        /// 货车选择策略，可选
        /// <para>默认值是1，值与GaoDeConst.truckStrategy对应</para>
        /// </summary>
        public int strategy = 1;
        /// <summary>
        /// 途经点，可选
        /// <para>格式为x1,y1;x2,y2，最多16个坐标点，如果输入多个途径点，则按照用户输入的顺序进行路径规划</para>
        /// </summary>
        public string waypoints;
        /// <summary>
        /// 车辆大小，必填
        /// <para>默认是2=轻型车，值与GaoDeConst.truckSize对应</para>
        /// </summary>
        public int size = 2;
        /// <summary>
        /// 车辆高度，单位米，可选
        /// <para>取值[0–25.5]米，默认 1.6 米，会严格按照填写数字进行限行规避，请按照车辆真实信息合理填写</para>
        /// </summary>
        public decimal height = new decimal(1.6);
        /// <summary>
        /// 车辆宽度，单位米，可选
        /// <para>取值[0–25.5]米，默认 2.5 米，会严格按照填写数字进行限行规避，请按照车辆真实信息合理填写</para>
        /// </summary>
        public decimal width = new decimal(2.5);
        /// <summary>
        /// 车辆总重，单位吨，可选
        /// <para>取值[0–6553.5]吨，默认 0.9 吨，会严格按照填写数字进行限行规避，请按照车辆真实信息合理填写</para>
        /// </summary>
        public decimal load = new decimal(0.9);
        /// <summary>
        /// 货车核定载重，单位吨，可选
        /// <para>取值[0–6553.5]吨，默认 10 吨，会严格按照填写数字进行限行规避，请按照车辆真实信息合理填写</para>
        /// </summary>
        public decimal weight = new decimal(10);
        /// <summary>
        /// 车辆轴数，单位个，可选
        /// <para>取值[0–255]个，默认 2个轴，会严格按照填写数字进行限行规避，请按照车辆真实信息合理填写</para>
        /// </summary>
        public int axis = 2;
        /// <summary>
        /// 车牌省份，可选
        /// <para>用汉字填入车牌省份缩写。用于判断是否限行</para>
        /// </summary>
        public string province;
        /// <summary>
        /// 车牌详情
        /// <para>填入除省份及标点之外的字母和数字（需大写），用于判断限行相关，支持6位传统车牌和7位新能源车牌</para>
        /// </summary>
        public string number;
        /// <summary>
        /// 车辆类型，可选
        /// <para>默认是0=普通货车，值与GaoDeConst.carType对应</para>
        /// </summary>
        public int cartype;
        /// <summary>
        /// 区域避让，可选
        /// <para>支持100个避让区域，每个区域最多可有16个顶点，每个区域的最大面积是100平方公里。经度和纬度用"",""分隔，坐标点之间用";"分隔，区域之间用"|"分隔</para>
        /// </summary>
        public string avoidpolygons;
        /// <summary>
        /// 是否返回路线数据，可选
        /// <para>当取值为1时，steps与tmcs下的polyline数据会正常返回；当取值为0时，steps与tmcs下的polyline数据返回""</para>
        /// </summary>
        public int showpolyline = 1;
        /// <summary>
        /// 是否返回steps字段内容，可选
        /// <para>当取值为0时，steps字段内容正常返回；当取值为1时，steps字段内容为空；</para>
        /// </summary>
        public int nosteps;
    }
}
