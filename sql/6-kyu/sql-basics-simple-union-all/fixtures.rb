results = run_sql

describe :query do
  describe "should contain keywords" do    
    it "should contain UNION ALL" do
      expect($sql.upcase).to include("UNION ALL")
    end
    
    it "should contain EU" do
      expect($sql.upcase).to include("EU")
    end
    
    it "should contain US" do
      expect($sql.upcase).to include("US")
    end
    
    it "should not contain JOIN" do
      expect($sql.upcase).not_to include("JOIN")
    end
  end

  describe :columns do
    it "should return 7 columns" do
      expect(results.first.keys.count).to eq 7
    end
    
    it "should return a location column" do
      expect(results.first.keys).to include(:location)
    end
    
    it "should return an id column" do
      expect(results.first.keys).to include(:id)
    end
    
    it "should return a name column" do
      expect(results.first.keys).to include(:name)
    end
    
    it "should return a price column" do
      expect(results.first.keys).to include(:price)
    end
    
    it "should return a card_name column" do
      expect(results.first.keys).to include(:card_name)
    end
    
    it "should return a card_number column" do
      expect(results.first.keys).to include(:card_number)
    end
    
    it "should return a transaction_date column" do
      expect(results.first.keys).to include(:transaction_date)
    end
  end
end