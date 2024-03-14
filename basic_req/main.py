def on_microbit_id_io_p20_evt():
    if AlarmType == 2:
        pins.digital_write_pin(DigitalPin.P2, 1)
        music.play(music.tone_playable(988, music.beat(BeatFraction.QUARTER)),
            music.PlaybackMode.LOOPING_IN_BACKGROUND)
        basic.show_leds("""
            . # # # .
            # # . # #
            # . . . #
            # # . # #
            . # # # .
            """)
    if AlarmType == 1:
        music.play(music.tone_playable(784, music.beat(BeatFraction.WHOLE)),
            music.PlaybackMode.LOOPING_IN_BACKGROUND)
        pins.digital_write_pin(DigitalPin.P1, 1)
        basic.show_leds("""
            # # # # #
            # . . . #
            # . . . #
            # . . . #
            # # # # #
            """)
control.on_event(EventBusSource.MICROBIT_ID_IO_P20,
    EventBusValue.MICROBIT_EVT_ANY,
    on_microbit_id_io_p20_evt)

ZForce = 0
YForce = 0
XForce = 0
Force = 0
AlarmType = 0
input.set_accelerometer_range(AcceleratorRange.EIGHT_G)
datalogger.set_column_titles("X-Force", "Y-Force", "Z-Force", "AbsoluteForce")

def on_forever():
    global Force, XForce, YForce, ZForce, AlarmType
    Force = input.acceleration(Dimension.STRENGTH)
    XForce = input.acceleration(Dimension.X)
    YForce = input.acceleration(Dimension.Y)
    ZForce = input.acceleration(Dimension.Z)
    if input.acceleration(Dimension.STRENGTH) >= 300:
        if Force >= 8000:
            AlarmType = 2
            control.raise_event(EventBusSource.MICROBIT_ID_IO_P20,
                EventBusValue.MES_ALERT_EVT_ALARM1)
        else:
            if Force >= 3000:
                AlarmType = 1
                control.raise_event(EventBusSource.MICROBIT_ID_IO_P20,
                    EventBusValue.MES_ALERT_EVT_ALARM1)
    datalogger.log(datalogger.create_cv("X-Force", XForce),
        datalogger.create_cv("Y-Force", YForce),
        datalogger.create_cv("Z-Force", ZForce),
        datalogger.create_cv("AbsoluteForce", Force))
basic.forever(on_forever)
