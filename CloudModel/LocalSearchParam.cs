using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap.CloudModel
{
    /// <summary>
    /// 云图数据查询抽象公共参数
    /// </summary>
    public abstract class DataSearchParam : CloudBaseParam
    {
        /// <summary>
        /// 数据表唯一标识，必填
        /// </summary>
        public string tableid;
        /// <summary>
        /// 搜索关键词，必填
        /// <para>支持0-9数字，大小写字母（a-z,A-Z）以及所有中文字符</para>
        /// <para>1. 请先在云图数据管理台添加或删除文本索引字段，系统默认为_name和_address建立文本索引；</para>
        /// <para>2. 支持关键字模糊检索，即对建立【文本索引字段】对应列内容进行模糊检索；如keywords=工商银行，检索返回已建立文本索引列值中包含“工商”或者“银行”或者“工商银行”关键字的POI结果集。</para>
        /// <para>3. 支持关键字“或”精准检索，即对建立【文本索引字段】对应列内容进行多关键字检索；如keywords=招商银行|华夏银行|工商银行，检索返回已建立索引列值中包含“招商银行”或者“华夏银行”或者“工商银行”的POI结果集，不会返回检索词切分后，如仅包含“招商”或者“银行”的POI集。</para>
        /// <para>4. 可赋值为空值，用空格表示空值；</para>
        /// <para>5. city=城市名&amp;keywords= （空格）或者是关键字，将返回对应城市的全部数据或对应关键字的数据；</para>
        /// <para>6. 一次请求最多返回2000条数据。</para>
        /// </summary>
        public string keywords;
        /// <summary>
        /// 过滤条件，可选
        ///<para>筛选条件：</para>
        ///<para>1.对建立【排序筛选索引字段】进行检索；</para>
        ///<para>2. 请在数据管理台添加或删除筛选排序索引字段，系统默认为_id，_name，_address，_updatetime，_createtime（其中_updatetime,_createtime暂只能用于排序，不能作为过滤字段）</para>
        ///<para>3. 支持多个筛选条件并行使用：多个过滤条件之间使用“+”（代表与关系）；</para>
        ///<para>4. 支持对文本类型的字段进行精确匹配；</para>
        ///<para>5. 支持对整数和小数字段的连续区间筛选。</para>
        ///<para>规则：</para>
        ///<para>filter=key1:value1+key2:[value2, value3]</para>
        ///<para>示例：</para>
        ///<para>filter=type:酒店+star:[3,5]</para>
        ///<para>（等同于SQL语句的：WHERE type = "酒店" AND star BETWEEN 3 AND 5）</para>
        /// </summary>
        public string filter;
        /// <summary>
        /// 排序规则，可选
        /// <para>两种方式排序：</para>
        /// <para>1.云图系统预设排序法：_weight：相关度权重值排序，返回由高到低的排序检索结果；</para>
        /// <para>规则:sortrule = _weight:0 //降序</para>
        /// <para>2. 支持对在云图数据管理台建立【排序筛选索引字段】的整数或小数字段排序；</para>
        /// <para>规则：</para>
        /// <para>sortrule=字段名:1 （升序）；</para>
        /// <para>sortrule=字段名:0 （降序）；</para>
        /// <para>示例：按年龄age字段升序排序，sortrule=age:1</para>
        /// </summary>
        public string sortrule;
        /// <summary>
        /// 分页数据条目数（每页数据展现的条数），可选
        /// <para>最大每页记录数为100</para>
        /// </summary>
        public int limit = 20;
        /// <summary>
        /// 分页索引，当前页数>=1，可选
        /// </summary>
        public int page = 1;
    }

    /// <summary>
    /// 本地检索查询参数
    /// </summary>
    public class LocalSearchParam : DataSearchParam
    {
        /// <summary>
        /// 设定检索的城市名（中文名称），必填
        /// <para>1. 支持全国/省/市/区县行政区划范围的检索；</para>
        ///<para>2. city=全国，即对用户全表搜索；</para>
        ///<para>3. 当city值设置非法或不正确时，按照city = 全国返回</para>
        /// </summary>
        public string city;
    }

    /// <summary>
    /// 周边检索查询参数
    /// </summary>
    public class AroundSearchParam : DataSearchParam
    {
        /// <summary>
        /// 中心点坐标，必填
        /// <para>规则：经度和纬度用","分割，经纬度小数点后不得超过6位</para>
        /// </summary>
        public string center;
        /// <summary>
        /// 查询半径，可选
        /// <para>规则：取值范围[0,50000]，单位：米。若超出取值范围按默认值</para>
        /// </summary>
        public int radius = 3000;
    }

    /// <summary>
    /// 多边形检索查询参数
    /// </summary>
    public class PolygonSearchParam : DataSearchParam
    {
        /// <summary>
        /// 中心点坐标，必填
        /// <para>规则：逗号分隔的一对经纬度代表一个坐标，用分号分割多个坐标；</para>
        ///<para>如果只传两个坐标则认为这两坐标为矩形的左下和右上点；</para>
        ///<para>多边形数据的起点和终点必须相同，保证图形闭合。</para>
        ///<para>示例:</para>
        ///<para>- 矩形：</para>
        ///<para>polygon=116.374634,39.377362;116.673646,39.576462</para>
        ///<para>- 多边形：</para>
        ///<para>polygon=115.7409668,40.12009038;115.59127808,39.98869502;115.8631897, 39.91816285;115.7409668,40.12009038</para>
        /// </summary>
        public string polygon;
    }

    /// <summary>
    /// id检索查询参数
    /// </summary>
    public class IDSearchParam : CloudBaseParam
    {
        /// <summary>
        /// 数据表唯一标识，必填
        /// </summary>
        public string tableid;
        /// <summary>
        /// 数据id，必填
        /// </summary>
        public string _id;
    }

    /// <summary>
    /// 云图按条件检索数据（可遍历整表数据）参数
    /// </summary>
    public class AllSearchParam : CloudBaseParam
    {
        /// <summary>
        /// 数据表唯一标识，必填
        /// </summary>
        public string tableid;
        /// <summary>
        /// 过滤条件，可选
        ///<para>筛选条件：</para>
        ///<para>1.对建立【排序筛选索引字段】进行检索；</para>
        ///<para>2. 请在数据管理台添加或删除筛选排序索引字段，系统默认为_id，_name，_address，_updatetime，_createtime（其中_updatetime,_createtime暂只能用于排序，不能作为过滤字段）</para>
        ///<para>3. 支持多个筛选条件并行使用：多个过滤条件之间使用“+”（代表与关系）；</para>
        ///<para>4. 支持对文本类型的字段进行精确匹配；</para>
        ///<para>5. 支持对整数和小数字段的连续区间筛选。</para>
        ///<para>规则：</para>
        ///<para>filter=key1:value1+key2:[value2, value3]</para>
        ///<para>示例：</para>
        ///<para>filter=type:酒店+star:[3,5]</para>
        ///<para>（等同于SQL语句的：WHERE type = "酒店" AND star BETWEEN 3 AND 5）</para>
        /// </summary>
        public string filter;
        /// <summary>
        /// 排序规则，可选
        /// <para>两种方式排序：</para>
        /// <para>1.云图系统预设排序法：_weight：相关度权重值排序，返回由高到低的排序检索结果；</para>
        /// <para>规则:sortrule = _weight:0 //降序</para>
        /// <para>2. 支持对在云图数据管理台建立【排序筛选索引字段】的整数或小数字段排序；</para>
        /// <para>规则：</para>
        /// <para>sortrule=字段名:1 （升序）；</para>
        /// <para>sortrule=字段名:0 （降序）；</para>
        /// <para>示例：按年龄age字段升序排序，sortrule=age:1</para>
        /// </summary>
        public string sortrule;
        /// <summary>
        /// 分页数据条目数（每页数据展现的条数），可选
        /// <para>最大每页记录数为100</para>
        /// </summary>
        public int limit = 20;
        /// <summary>
        /// 分页索引，当前页数>=1，可选
        /// </summary>
        public int page = 1;
    }

    /// <summary>
    /// 云图数据区域分布检索基础参数
    /// </summary>
    public abstract class AreaSearchParam : CloudBaseParam
    {
        /// <summary>
        /// 数据表唯一标识，必填
        /// </summary>
        public string tableid;
        /// <summary>
        /// 搜索关键词，必填
        /// <para>支持0-9数字，大小写字母（a-z,A-Z）以及所有中文字符</para>
        /// <para>1. 请先在云图数据管理台添加或删除文本索引字段，系统默认为_name和_address建立文本索引；</para>
        /// <para>2. 支持关键字模糊检索，即对建立【文本索引字段】对应列内容进行模糊检索；如keywords=工商银行，检索返回已建立文本索引列值中包含“工商”或者“银行”或者“工商银行”关键字的POI结果集。</para>
        /// <para>3. 支持关键字“或”精准检索，即对建立【文本索引字段】对应列内容进行多关键字检索；如keywords=招商银行|华夏银行|工商银行，检索返回已建立索引列值中包含“招商银行”或者“华夏银行”或者“工商银行”的POI结果集，不会返回检索词切分后，如仅包含“招商”或者“银行”的POI集。</para>
        /// <para>4. 可赋值为空值，用空格表示空值；</para>
        /// </summary>
        public string keywords;
        /// <summary>
        /// 过滤条件，可选
        ///<para>筛选条件：</para>
        ///<para>1.对建立【排序筛选索引字段】进行检索；</para>
        ///<para>2. 请在数据管理台添加或删除筛选排序索引字段，系统默认为_id，_name，_address，_updatetime，_createtime（其中_updatetime,_createtime暂只能用于排序，不能作为过滤字段）</para>
        ///<para>3. 支持多个筛选条件并行使用：多个过滤条件之间使用“+”（代表与关系）；</para>
        ///<para>4. 支持对文本类型的字段进行精确匹配；</para>
        ///<para>5. 支持对整数和小数字段的连续区间筛选。</para>
        ///<para>规则：</para>
        ///<para>filter=key1:value1+key2:[value2, value3]</para>
        ///<para>示例：</para>
        ///<para>filter=type:酒店+star:[3,5]</para>
        ///<para>（等同于SQL语句的：WHERE type = "酒店" AND star BETWEEN 3 AND 5）</para>
        /// </summary>
        public string filter;
        /// <summary>
        /// 回调函数，可选
        /// </summary>
        public string callback;
    }

    /// <summary>
    /// 云图省数据分布检索参数
    /// </summary>
    public class ProvinceSearchParam : AreaSearchParam
    {
        /// <summary>
        /// 指定所需查询的国家名（目前仅支持中国)，可选
        /// </summary>
        public string country = "中国";
    }

    /// <summary>
    /// 云图城市数据分布检索参数
    /// </summary>
    public class CitySearchParam : AreaSearchParam
    {
        /// <summary>
        /// 指定所需查询的省，可选
        /// <para>规则： 省中文名称；</para>
        ///<para>说明：</para>
        ///<para>1. province = 全国，返回含有数据的所有市名称以及对应数据量，并根据数据量从高到低排行；</para>
        ///<para>2. province = 山东，返回沈阳含有数据的所有市名称以及对应数据量，并根据数据量从高到低排行</para>
        /// </summary>
        public string province = "全国";
    }

    /// <summary>
    /// 云图区县数据分布检索参数
    /// </summary>
    public class DistrictSearchParam : AreaSearchParam
    {
        /// <summary>
        /// 指定所需查询的城市，必填
        /// <para>规则： 城市中文名称；</para>
        /// </summary>
        public string city;
    }
}
