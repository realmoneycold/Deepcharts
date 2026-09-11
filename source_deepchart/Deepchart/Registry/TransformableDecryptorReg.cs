using System.Collections.Generic;
using System.Threading.Tasks;
using Deepchart.Location;

namespace Deepchart.Registry;

internal delegate Task<bool> TransformableDecryptorReg(HiddenLocatorLocator connection, string clientIpAddress, Dictionary<string, string> queryParams);
