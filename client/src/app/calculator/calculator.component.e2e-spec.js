describe('Calculator', function () {

  beforeEach(function () {
    browser.get('/');
  });

  it('should have <calculator>', function () {
    var home = element(by.css('app calculator'));
    expect(home.isPresent()).toEqual(true);
    // expect(home.getText()).toEqual("Home Works!");
  });

});
