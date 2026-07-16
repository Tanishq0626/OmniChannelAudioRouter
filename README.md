OmniChannel Audio Router
OmniChannel Audio Router is a native Windows desktop utility designed for high-performance, real-time audio stream routing. Built on the .NET 8 framework using WPF (Windows Presentation Foundation) and styled with the Material Design in XAML Toolkit, this application provides an intuitive, hardware-accelerated dashboard to manage and synchronize multiple local audio outputs simultaneously.

The application solves the challenge of splitting and routing audio streams across mismatched hardware endpoints—such as HDMI TV speakers, Bluetooth subwoofers, and 3.5mm headphone jacks—with independent, high-precision control per channel block.

🚀 Key Features
3-Channel Parallel Routing Matrix: Map and stream audio to three independent target hardware devices simultaneously.

Matrix Audio Layouts: Built-in downmixing configurations per channel, supporting 1.0 Only Subwoofer (Mono Downmix), 2.0 Native Stereo, 2.1 Satellites Matrix, and 5.1 Immersive Theater Links.

Manual Latency Tuning: Precision text-input buffers (in milliseconds) per channel to manually align hardware streams and eliminate wireless audio drift.

Volume Safety Limiters: Independent processing ceilings clamped smoothly inside the backend audio processing loop to protect hardware endpoints from spikes.

Hardware-Accelerated UI: Fully offloads layout rendering to the GPU via DirectX, leaving CPU cores entirely unhindered for time-sensitive audio array math.

🏗️ Core Architecture Pillars
The software architecture is engineered using five advanced .NET design patterns to handle the demands of real-time stream processing:

Encapsulation Guard Rails: Native C# properties wrapping the internal processing engine variables with strict data validation gates.

Asynchronous Subsystems (async/await): Time-consuming hardware scanning routines are offloaded to background worker threads via Task.Run(), keeping the interface fluid and avoiding OS freezes.

Shared Memory Synchronization: Thread-safe data piping utilizing execution primitives (lock statements) to prevent race conditions or sample corruption between the real-time capture and playback loops.

Event-Driven Publisher Design: Uses C# event handlers (+=) and Lambda expressions (=>) to listen to system events, providing smooth transitions during hot-plugging triggers like Bluetooth dropouts.

Bi-directional Data Binding: Built using the MVVM design pattern leveraging the INotifyPropertyChanged interface, welding XAML visual components directly to backend mathematical coefficients without manual listener boilerplate.

🛠️ Built With
Language: C#

Framework: .NET 8.0 (Windows Architecture)

UI Engine: WPF (Windows Presentation Foundation)

Design Framework: Material Design in XAML Toolkit

Audio Pipeline: NAudio Integration
