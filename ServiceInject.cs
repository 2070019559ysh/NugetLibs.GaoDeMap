﻿using Microsoft.Extensions.DependencyInjection;
using NugetLibs.GaoDeMap.CloudService;
using NugetLibs.GaoDeMap.WebService;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetLibs.GaoDeMap
{
    /// <summary>
    /// 高德帮助库默认的依赖注入（Denpendency Injection)
    /// </summary>
    public class ServiceInject
    {
        /// <summary>
        /// 配置高德地图SDK所有依赖的服务
        /// </summary>
        /// <param name="services">依赖服务集合</param>
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IGeographyService, GeographyService>();
            services.AddScoped<IDirectionService, DirectionService>();
            services.AddScoped<IAdminRegionService, AdminRegionService>();
            services.AddScoped<IPOIPlaceService, POIPlaceService>();
            services.AddScoped<IIPLocationService, IPLocationService>();
            services.AddScoped<IBatchService, BatchService>();
            services.AddScoped<IStaticMapService, StaticMapService>();
            services.AddScoped<ICoordinateService, CoordinateService>();
            services.AddScoped<IWeatherQueryService, WeatherQueryService>();
            services.AddScoped<IInputQueryService, InputQueryService>();
            services.AddScoped<ITrafficSituationService, TrafficSituationService>();
            services.AddScoped<IGeoFenceService, GeoFenceService>();
            services.AddScoped<IGraspRoadService, GraspRoadService>();
            services.AddScoped<ICloudDataService, CloudDataService>();
            services.AddScoped<IDataSearchService, DataSearchService>();
        }
    }
}
