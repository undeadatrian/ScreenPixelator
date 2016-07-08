ScreenPixelator
===============

A simple client to send pixelpackets.
Takes an area of the desktop and sends it to a pixelpacket server.

Instructions
------------
Import the project in Visual Studio and run the code.

You can use the X and Y number boxes to set the size of your display.

Click show to define the area of the desktop that needs to be captured, you can move the box by using the arrow image and resize the box keeping the aspect ratio of your matrix, click hide to hide the box on the display.

Set the ip and port of your pixelpacket server and click Start output to start sending the packets.

The packets are sends every 1/6 seconds, any more and the server crashes (I should investigate this).

Click Get pixels to display the pixeldata in a human readable format in the textbox.
