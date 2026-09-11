using System.Net.WebSockets;
using System.Threading.Tasks;
using Deepchart.Location;

namespace Deepchart.Registry;

internal delegate Task CentralSynchronizerReg(HiddenLocatorLocator connection, bool isUnexpected, string reason, WebSocketCloseStatus? closeStatus);
