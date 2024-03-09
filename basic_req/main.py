Force = 0
AlarmType = 0

input.set_accelerometer_range(AcceleratorRange.EIGHT_G)
datalogger.set_column_titles("force")

def on_microbit_id_io_p20_evt():
    global AlarmType
    if AlarmType == 2:
        pins.digital_write_pin(DigitalPin.P2, 1)
        basic.show_leds("""
            . . . . .
            . # . # .
            . . # . .
            . # . # .
            . . . . .
            """)
    pins.digital_write_pin(DigitalPin.P1, 1)
    basic.show_leds("""
        # # # # #
        # . . . #
        # . . . #
        # . . . #
        # # # # #
        """)
    control.wait_micros(50)
    AlarmType = 0
    pins.digital_write_pin(DigitalPin.P1, 0)
    pins.digital_write_pin(DigitalPin.P2, 0)
    control.on_event(EventBusSource.MICROBIT_ID_IO_P20, EventBusValue.MICROBIT_EVT_ANY, on_microbit_id_io_p20_evt)

def on_forever():
    global Force, AlarmType
    if input.acceleration(Dimension.STRENGTH) >= 300:
        Force = input.acceleration(Dimension.STRENGTH)
        if Force >= 2000:
            if Force >= 8000:
                AlarmType = 2
            else:
                AlarmType = 1
            control.raise_event(EventBusSource.MICROBIT_ID_IO_P20,
                EventBusValue.MES_ALERT_EVT_ALARM1)
        else:
            AlarmType = 0
        datalogger.log(datalogger.create_cv("force", Force))

basic.forever(on_forever)
